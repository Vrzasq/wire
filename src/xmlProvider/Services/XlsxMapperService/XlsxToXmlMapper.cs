using xmlProvider;

namespace xmlObjectProvider.Services.XlsxMapperService;

public class XlsxToXmlMapper : IXlsxToXmlMapper
{
    private readonly IEnumerable<IXmlMapper> _mappers;

    public XlsxToXmlMapper(IEnumerable<IXmlMapper> mappers)
    {
        _mappers = mappers;
    }

    public IAsyncEnumerable<XmlMapperResult> GetXmlsAsync(XmlMapperParameters parameters)
    {
        var mapper = _mappers.FirstOrDefault(x => x.XmlObjectType == parameters.XmlObjectType);

        return mapper.GetXmlsAsync(parameters);
    }
}
