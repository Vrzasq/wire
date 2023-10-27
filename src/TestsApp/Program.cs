// See https://aka.ms/new-console-template for more information
using MiniExcelLibs;
using MiniExcelLibs.Attributes;


var rand = new Random();

var test = Enumerable.Range(0, 100).Select(x => new SomeClass
{
    Name = rand.Next(0, 1000).ToString(),
    Surname = rand.Next(0, 1000).ToString(),
    Test = rand.Next(0, 1000).ToString(),
    MMo1 = rand.Next(0, 1000).ToString(),
    Mmo2 = rand.Next(0, 1000).ToString()
}).ToArray();

MiniExcel.SaveAs("wololololo.xlsx", test, excelType: ExcelType.XLSX, overwriteFile: true);

class SomeClass
{
    [ExcelColumn(Index = 0, Name = nameof(Name))]
    public string Name { get; set; }

    [ExcelColumn(Index = 0, Name = nameof(Name))]
    public string Surname { get; set; }

    [ExcelColumn(Index = 0, Name = nameof(Name))]
    public string Test { get; set; }

    [ExcelColumn(Index = 0, Name = nameof(Name))]
    public string MMo1 { get; set; }

    [ExcelColumn(Index = 0, Name = nameof(Name))]
    public string Mmo2 { get; set; }
}