using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace xmlObjectProvider.Services.XlsxMapperService;

public static class XmlMapperExtensions
{
    private static readonly XmlWriterSettings _settings = new()
    {
        Async = true,
        CloseOutput = true,
        Encoding = Encoding.UTF8,
        Indent = true,
    };

    public static string ToXml<T>(this T obj)
    {
        if (obj is null)
            throw new ArgumentNullException(nameof(obj));

        var serializer = new XmlSerializer(obj.GetType());
        using var writer = new Utf8StringWriter();
        using var xmlWriter = XmlWriter.Create(writer, _settings);
        serializer.Serialize(xmlWriter, obj);

        return writer.ToString();
    }
}
