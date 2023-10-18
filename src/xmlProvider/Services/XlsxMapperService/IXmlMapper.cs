namespace xmlObjectProvider.Services.XlsxMapperService;

internal interface IXmlMapper
{
    IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(XmlMapperParameters parameters);
}
