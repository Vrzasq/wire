namespace xmlObjectProvider.Services.XlsxMapperService;

public interface IXlsxToXmlMapper
{
    IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(XmlMapperParameters parameters);
}
