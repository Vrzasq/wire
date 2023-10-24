using MiniExcelLibs.Attributes;
using System.Reflection;

namespace xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSEB;

internal static class ZUSEBExcelModelExtensions
{
    private const string Godzina = "godzina";

    public static IEnumerable<(
        int godzina,
        int kwadrans,
        decimal value
        )> GetHourlySchedule(this ZUSEBExcelModel model)
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
}    
