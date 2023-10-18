using MiniExcelLibs.Attributes;
using System.Reflection;

namespace xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSE;

internal static class ZUSEExcelModelExtensions
{
    private const string Godzina = "godzina";

    public static IEnumerable<(
        int godzina,
        int kwadrans,
        decimal value
        )> GetHourlySchedule(this ZUSEExcelModel model)
    {
        return model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.Name.Contains(Godzina, StringComparison.InvariantCultureIgnoreCase))
            .OrderBy(p => p.GetCustomAttribute<ExcelColumnIndexAttribute>()?.ExcelColumnIndex)
            .Select((p, i) =>
            (
                godzina: i + 1,
                kwadrans: model.Kwadrans,
                value: (p.GetValue(model) as decimal?) ?? 0 
            ));
    }

    /// <summary>
    /// returns do
    /// </summary>
    /// <returns></returns>
    public static DateTime DobaHandlowaUtc(this ZUSEExcelModel model)
    {
        if (model is null) throw new ArgumentNullException(nameof(model));

        return model.DobaHandlowa.ToUniversalTime().Date;
    }
}    
