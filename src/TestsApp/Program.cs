// See https://aka.ms/new-console-template for more information
using xmlObjectProvider.Services.XlsxMapperService;
using xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSE;
using xmlProvider;

var filePath = new FileInfo("test.xlsx");
var fileInfo = new XlsxFileInfo(filePath.FullName, filePath.Name);
var businessParameters = new BusinessParameters(1, "+48 504 259 771", "PO_0000Test", "OR_0000Test");
var parameters = new XmlMapperParameters(new[] { fileInfo }, XmlObjectType.ZUSE, businessParameters);
var mapper = new ZUSEMapper();

await foreach(var xml in mapper.GetXmlsAsync(parameters))
{
    File.WriteAllText(xml.FileName, xml.Content);
}

Console.WriteLine("Hello, World!");