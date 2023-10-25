// See https://aka.ms/new-console-template for more information
using MiniExcelLibs;
using xmlObjectProvider.Services.XlsxMapperService;
using xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSE;
using xmlProvider;

var filePath = new FileInfo("test.xlsx");
var fileInfo = new XlsxFileInfo(filePath.FullName, filePath.Name);
var configuration = MiniExcel.Query("balance_units.xlsx", excelType: ExcelType.XLSX, startCell: "A2")
    .Select(row => new BalanceUnitConfiguration(row.A, row.B, row.C))
            .ToArray();
var businessParameters = new BusinessParameters(1, "+48 504 259 771", "PO_0000Test", configuration);
var parameters = new XmlMapperParameters(new[] { fileInfo }, XmlObjectType.ZUSE, businessParameters);
var mapper = new ZUSEMapper();

await foreach(var xml in mapper.GetXmlsAsync(parameters))
{
    File.WriteAllText(xml.FileName, xml.Content);
}

Console.WriteLine("Hello, World!");