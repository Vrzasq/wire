using System.Text;

namespace xmlObjectProvider.Services.XlsxMapperService;

public class Utf8StringWriter : StringWriter
{
    public override Encoding Encoding => Encoding.UTF8;
}
