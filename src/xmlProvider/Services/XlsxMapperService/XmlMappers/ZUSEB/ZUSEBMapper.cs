using MiniExcelLibs;
using xmlObjectProvider.Objects.generated.ZUSEB;
using xmlProvider;

namespace xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSEB;

public class ZUSEBMapper : IXmlMapper
{
    private const string Wersja = "WIRE 14.0";
    private const string R = "PT15M";
    private const string StartCell = "A1";
    private const string FileNameMask = "ZUSB_{0}_{1}.xml";
    private const string DateFormat = "yyyy-MM-dd";

    public XmlObjectType XmlObjectType => XmlObjectType.ZUSEB;

    public async IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(XmlMapperParameters parameters)
    {
        foreach (var xlsxPath in parameters.XlsxFileInfos)
        {
            await foreach (var xmlResult in GetXmlsAsync(xlsxPath, parameters).ConfigureAwait(false))
                yield return xmlResult;
        }
    }

    private async IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(
        XlsxFileInfo fileInfo,
        XmlMapperParameters parameters)
    {
        // there can be more than one xml from one excel file
        // file need to be grupped per 'DobaHandlowa' and 'KodJbZglaszanej'
        var xmlSources = (await MiniExcel.QueryAsync<ZUSEBExcelModel>(fileInfo.XlsxPath, startCell: StartCell).ConfigureAwait(false))
            .Where(x => !string.IsNullOrWhiteSpace(x.KodJbZglaszanej))
            .GroupBy(x => (x.KodJbZglaszanej, x.DobaHandlowa));

        foreach (var xmlSource in xmlSources)
        {
            var komunikat = GetKomunikat(parameters, xmlSource);

            var result = new XmlMapperResult(
                FileName: GetFileName(komunikat),
                Content: komunikat.ToXml());

            yield return result;
        }
    }

    private static string GetFileName(Komunikat komunikat) =>
        string.Format(FileNameMask,
            komunikat.Tresc.USEB.KJB, DateTime.UtcNow.Date.ToString(DateFormat));

    private Komunikat GetKomunikat(
        XmlMapperParameters parameters,
        IEnumerable<ZUSEBExcelModel> relatedRows)
    {
        var naglowek = GetNaglowek(relatedRows.First());
        var tresc = GetTresc(parameters, relatedRows);

        return new Komunikat
        {
            Naglowek = naglowek,
            Tresc = tresc,
        };
    }

    private static tTresc GetTresc(
        XmlMapperParameters parameters,
        IEnumerable<ZUSEBExcelModel> relatedRows)
    {
        var referenceModel = relatedRows.First();
        var (startDate, endDate) = referenceModel.DobaHandlowa.ToDobaHandlowa();
        var businessParams = parameters.BusinessParameters;
        var ts = GetTs(parameters, relatedRows).ToArray();

        return new tTresc
        {
            USEB = new tZUSEB
            {
                mRID = Guid.NewGuid().ToString(),
                W = businessParams.W.ToString(),
                DT = new tOkres { DTS = startDate, DTK = endDate },
                IDOT = parameters.BusinessParameters.IDOT,
                KJB = referenceModel.KodJbZglaszanej,
                KO = referenceModel.KodJbPartneraHandlowego,
                KPOB = businessParams.KPOB,
                TS = ts
            }
        };
    }

    private static IEnumerable<tGrafikZgloszenia> GetTs(
        XmlMapperParameters parameters,
        IEnumerable<ZUSEBExcelModel> relatedRows)
    {
        var ts = relatedRows.GroupBy(x => x.KodJbPartneraHandlowego).ToArray();
        var referanceRow = relatedRows.First();
        var (startDate, endDate) = referanceRow.DobaHandlowa.ToDobaHandlowa();

        foreach (var currentT in ts)
        {
            var t = GetTDaneIlosciowe(currentT).ToArray();

            var grafikZloszen = new tGrafikZgloszenia
            {
                KJB = currentT.Key,
                KO = parameters.BusinessParameters.KO,
                mRID = Guid.NewGuid().ToString(),
                TSP = new tOkresZgloszenia
                {
                    DT = new tOkres { DTS = startDate, DTK = endDate },
                    R = R,
                    T = t
                }
            };

            yield return grafikZloszen;
        }
    }

    private static IEnumerable<tDaneIlosciowe> GetTDaneIlosciowe(IEnumerable<ZUSEBExcelModel> relatedRows)
    {
        return  relatedRows.SelectMany(x => x.GetHourlySchedule())
            .OrderBy(x => x.godzina)
            .ThenBy(x => x.kwadrans)
            .Select((x, i) => new tDaneIlosciowe
            {
                P = (i + 1).ToString(),
                Q = x.value
            })
            .OrderBy(x => int.Parse(x.P));
    }

    private Naglowek GetNaglowek(ZUSEBExcelModel model) =>
        new()
        {
            kod_kom = XmlObjectType,
            data = model.DobaHandlowa.Date,
            data_utworzenia = DateTime.Now,
            id = Guid.NewGuid().ToString(),
            kod_obiektu = model.KodJbZglaszanej,
            ref_id = string.Empty,
            wersja = Wersja,
        };
}
