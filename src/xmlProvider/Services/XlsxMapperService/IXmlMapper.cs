using xmlProvider;

namespace xmlObjectProvider.Services.XlsxMapperService;

public interface IXmlMapper
{
    XmlObjectType XmlObjectType { get; }
    IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(XmlMapperParameters parameters);
}
