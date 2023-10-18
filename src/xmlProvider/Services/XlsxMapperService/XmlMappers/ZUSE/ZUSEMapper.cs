using MiniExcelLibs;
using System.Xml.Serialization;
using xmlObjectProvider.Objects.ZUSE;

namespace xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSE;

public class ZUSEMapper : IXmlMapper
{
    private const string KodKom = "ZUSE";
    private const string Wersja = "WIRE 14.0";
    private const string R = "PT15M";
    private const string StartCell = "A1";
    private const string FileNameMask = "ZUSE_{0}_{1}.xml";
    private const string DateFormat = "yyyy_MM_dd";

    public async IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(XmlMapperParameters parameters)
    {
        foreach (var xlsxPath in parameters.XslxFileInfos)
        {
            await foreach (var xmlResult in GetXmlsAsync(xlsxPath, parameters))
                yield return xmlResult;
        }
    }

    private static async IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(
        XlsxFileInfo fileInfo,
        XmlMapperParameters parameters)
    {
        // there can be more than one xml from one excel file
        // file need to be grupped per 'DobaHandlowa' and 'KodJbZglaszanej'
        var xmlSources = (await MiniExcel.QueryAsync<ZUSEExcelModel>(fileInfo.XlsxPath, startCell: StartCell))
            .Where(x => !string.IsNullOrWhiteSpace(x.KodJbZglaszanej))
            .GroupBy(x => (x.KodJbZglaszanej, x.DobaHandlowa))
            .ToArray();

        foreach (var xmlSource in xmlSources)
        {
            var komunikat = GetKomunikat(parameters, xmlSource);

            var xmlSerializer = new XmlSerializer(komunikat.GetType());
            using var writer = new StringWriter();
            xmlSerializer.Serialize(writer, komunikat);
            writer.Flush();

            var result = new XmlMapperResult(
                FileName: GetFileName(komunikat),
                Content: writer.ToString());

            yield return result;
        }
    }

    private static string GetFileName(Komunikat komunikat) =>
        string.Format(FileNameMask,
            komunikat.Tresc.USE.KJB, DateTime.UtcNow.Date.ToString(DateFormat));

    private static Komunikat GetKomunikat(
        XmlMapperParameters parameters,
        IEnumerable<ZUSEExcelModel> relatedRows)
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
        IEnumerable<ZUSEExcelModel> relatedRows)
    {
        var referenceModel = relatedRows.First();
        var dobaHandlowaUtc = referenceModel.DobaHandlowaUtc();
        var businessParams = parameters.BusinessParameters;
        var ts = GetTs(parameters, relatedRows).ToArray();

        return new tTresc
        {
            USE = new tZUSE
            {
                mRID = Guid.NewGuid().ToString(),
                W = businessParams.W.ToString(),
                DT = new tOkres { DTS = dobaHandlowaUtc, DTK = dobaHandlowaUtc },
                IDOT = parameters.BusinessParameters.IDOT,
                KJB = referenceModel.KodJbZglaszanej,
                KO = referenceModel.KodJbPartneraHandlowego,
                KPOB = businessParams.KBOP,
                TS = ts
            }
        };
    }

    private static IEnumerable<tGrafikZgloszenia> GetTs(
        XmlMapperParameters parameters,
        IEnumerable<ZUSEExcelModel> relatedRows)
    {
        var ts = relatedRows.GroupBy(x => x.KodJbPartneraHandlowego).ToArray();
        var referanceRow = relatedRows.First();
        var dobaHandlowaUc = referanceRow.DobaHandlowaUtc();

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
                    DT = new tOkres { DTK = dobaHandlowaUc, DTS = dobaHandlowaUc },
                    R = R,
                    T = t
                }
            };

            yield return grafikZloszen;
        }
    }

    private static IEnumerable<tDaneIlosciowe> GetTDaneIlosciowe(IEnumerable<ZUSEExcelModel> relatedRows)
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

    private static Naglowek GetNaglowek(ZUSEExcelModel model) =>
        new()
        {
            kod_kom = KodKom,
            data = DateTime.UtcNow,
            data_utworzenia = DateTime.UtcNow,
            id = Guid.NewGuid().ToString(),
            kod_obiektu = model.KodJbZglaszanej,
            ref_id = string.Empty,
            wersja = Wersja,
        };
}
