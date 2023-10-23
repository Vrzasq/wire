using System.Text;

namespace xmlObjectProvider.Services.XlsxMapperService;

internal class Utf8StringWriter : StringWriter
{
    public override Encoding Encoding => Encoding.UTF8;
}
