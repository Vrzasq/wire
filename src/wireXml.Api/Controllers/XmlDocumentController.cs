using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using xmlObjectProvider.Objects;
using xmlObjectProvider.Services.XlsxMapperService;

namespace wireXml.Api.Controllers;

public class XmlDocumentController : ControllerBase
{
    [HttpPost("GetDataFromXml")]
    [Consumes("application/xml")]
    public Task<object> Post([FromBody] Komunikat obobj)
    {
        string sss = obobj.ToXml();
        return Task.FromResult<object>(new { a = 1 });
    }

    [HttpPost("GetDataFromXmlString")]
    public Task<object> Post()
    {
        using var lol = Request.BodyReader.AsStream();
        //using var textReader = new StringReader(obobj.Content);
        var serializer = new XmlSerializer(typeof(Komunikat));
        var obj = serializer.Deserialize(lol) as Komunikat;
        return Task.FromResult<object>(new { a = 1 });
    }

    public class Test90
    {
        public string Content { get; set; }
    }
}
