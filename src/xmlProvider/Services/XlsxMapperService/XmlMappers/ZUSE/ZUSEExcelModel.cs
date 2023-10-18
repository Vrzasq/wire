using MiniExcelLibs.Attributes;

namespace xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSE;

internal record ZUSEExcelModel
{
    [ExcelColumnIndex(0)]
    public string KodJbZglaszanej { get; init; } = string.Empty;
    [ExcelColumnIndex(1)]
    public string KodJbPartneraHandlowego { get; init; } = string.Empty;
    [ExcelColumnIndex(2)]
    public DateTime DobaHandlowa { get; init; }
    [ExcelColumnIndex(3)]
    public int Kwadrans { get; init; }
    [ExcelColumnIndex(4)]
    public decimal Godzina1 { get; init; }
    [ExcelColumnIndex(5)]
    public decimal Godzina2 { get; init; }
    [ExcelColumnIndex(6)]
    public decimal Godzina3 { get; init; }
    [ExcelColumnIndex(7)]
    public decimal Godzina4 { get; init; }
    [ExcelColumnIndex(8)]
    public decimal Godzina5 { get; init; }
    [ExcelColumnIndex(9)]
    public decimal Godzina6 { get; init; }
    [ExcelColumnIndex(10)]
    public decimal Godzina7 { get; init; }
    [ExcelColumnIndex(11)]
    public decimal Godzina8 { get; init; }
    [ExcelColumnIndex(12)]
    public decimal Godzina9 { get; init; }
    [ExcelColumnIndex(13)]
    public decimal Godzina10 { get; init; }
    [ExcelColumnIndex(14)]
    public decimal Godzina11 { get; init; }
    [ExcelColumnIndex(15)]
    public decimal Godzina12 { get; init; }
    [ExcelColumnIndex(16)]
    public decimal Godzina13 { get; init; }
    [ExcelColumnIndex(17)]
    public decimal Godzina14 { get; init; }
    [ExcelColumnIndex(18)]
    public decimal Godzina15 { get; init; }
    [ExcelColumnIndex(19)]
    public decimal Godzina16 { get; init; }
    [ExcelColumnIndex(20)]
    public decimal Godzina17 { get; init; }
    [ExcelColumnIndex(21)]
    public decimal Godzina18 { get; init; }
    [ExcelColumnIndex(22)]
    public decimal Godzina19 { get; init; }
    [ExcelColumnIndex(23)]
    public decimal Godzina20 { get; init; }
    [ExcelColumnIndex(24)]
    public decimal Godzina21 { get; init; }
    [ExcelColumnIndex(25)]
    public decimal Godzina22 { get; init; }
    [ExcelColumnIndex(26)]
    public decimal Godzina23 { get; init; }
    [ExcelColumnIndex(27)]
    public decimal Godzina24 { get; init; }
}    
