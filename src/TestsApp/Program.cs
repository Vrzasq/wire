// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using xmlObjectProvider.Objects;
using xmlObjectProvider.Services.XlsxMapperService;

var _settings = new XmlWriterSettings
{
    Async = true,
    CloseOutput = true,
    Encoding = Encoding.UTF8,
    Indent = true,
};

using var file = new FileStream("RDEW.xml", FileMode.Open);
var serializer = new XmlSerializer(typeof(Komunikat));
var obj = serializer.Deserialize(file) as Komunikat;

var testXml = obj.ToXml();
File.WriteAllText("RDEW_test.xml", testXml);


//Console.WriteLine(obj?.Tresc.USE?.mRID);

var naglowek = new Naglowek
{
    data = DateTime.UtcNow,
    kod_kom = "ZGWM",
    kod_obiektu = "8a7sd9asdakjshd",
    ref_id = Guid.NewGuid().ToString()
};

//var komunikat = new Komunikat
//{
//    Naglowek = naglowek,
//    Tresc = new Tresc
//    {
//        PPE = new PPE
//        {
//            DT = null,
//            DTK = null,
//            DTS = null,
//            KO = "KO",
//            mRID = Guid.NewGuid().ToString(),
//            KPPE = "KPPE",
//            W = 0
//        }
//    }
//};

//string xml = komunikat.ToXml();
//Console.WriteLine(xml);

//File.WriteAllText("PPE.xml", xml);

//using var file = new FileStream("PPE.xml", FileMode.Open);
//var testZGWM = serializer.Deserialize(file) as Komunikat;

//Console.WriteLine(testZGWM);

//var k = new[] { new KomunikatWeryfikacji { TK = "asdasda" } };

//var tresc = new Tresc
//{
//    USEB = new ZUSE_ZUSEB
//    {
//        DT = new Okres { DTK = DateTime.UtcNow, DTS = DateTime.UtcNow.AddDays(1) },
//        IDOT = null,
//        IIW = "IIW",
//        KJB = "KJB",
//        KO = "KO",
//        KPOB = "KPOB",
//        mRID = Guid.NewGuid().ToString(),
//        rmRID = Guid.NewGuid().ToString(),
//        K = [new KomunikatWeryfikacji { TK = "asdasda" }],
//        VDT = new Okres { DTK = DateTime.UtcNow, DTS = DateTime.UtcNow.AddDays(1) },
//        VS = StatusWeryfikacji.D,
//        W = 1,
//        TS = [new GrafikZUSE_ZUSEB
//        {
//            K = [new KomunikatWeryfikacji { TK = "asdasda" }, new KomunikatWeryfikacji { TK = "asdasda222222" }],
//            KJB = "KJB",
//            KO = "KO",
//            mRID = Guid.NewGuid().ToString(),
//            TSP = new OkresZgloszenia<DaneIloscioweZUSE_ZUSEB>
//            {
//                DT = new Okres { DTK = DateTime.UtcNow, DTS = DateTime.UtcNow.AddDays(1) },
//                R = "PT15M",
//                T = [
//                    new DaneIloscioweZUSE_ZUSEB { P = 1, Q = .5m }
//                ]
//            }
//        }]
//    },
//    USE = new ZUSE_ZUSEB
//    {
//        DT = new Okres { DTK = DateTime.UtcNow, DTS = DateTime.UtcNow.AddDays(1) },
//        IDOT = "IDOT",
//        IIW = "IIW",
//        KJB = "KJB",
//        KO = "KO",
//        KPOB = "KPOB",
//        mRID = Guid.NewGuid().ToString(),
//        rmRID = Guid.NewGuid().ToString(),
//        K = k,
//        VDT = new Okres { DTK = DateTime.UtcNow, DTS = DateTime.UtcNow.AddDays(1) },
//        VS = StatusWeryfikacji.D,
//        W = 1,
//        TS = new[] { new GrafikZUSE_ZUSEB
//        {
//            K = [new KomunikatWeryfikacji { TK = "asdasda" }, new KomunikatWeryfikacji { TK = "asdasda222222" }],
//            KJB = "KJB",
//            KO = "KO",
//            mRID = Guid.NewGuid().ToString(),
//            TSP = new OkresZgloszenia<DaneIloscioweZUSE_ZUSEB>
//            {
//                DT = new Okres { DTK = DateTime.UtcNow, DTS = DateTime.UtcNow.AddDays(1) },
//                R = "PT15M",
//                T = [
//                    new DaneIloscioweZUSE_ZUSEB { P = 1, Q = 1.5m },

//                    new DaneIloscioweZUSE_ZUSEB { P = 1, Q = .5m }
//                ]
//            },
//            VS = null
//        } }
//    }
//};


//var komunikat = new Komunikat
//{
//    Naglowek = naglowek,
//    Tresc = tresc
//};
//string xml = komunikat.ToXml();

//File.WriteAllText("wwww_testTest.xml", xml);


//using var file = new FileStream("test_zuse.xml", new FileStreamOptions { Access = FileAccess.Read, Mode = FileMode.Open });
//using var xmlReader = XmlReader.Create(file, new XmlReaderSettings { CloseInput = true });
//xmlReader.MoveToContent();
//while (xmlReader.Read())
//{
//    Console.WriteLine($"name: { xmlReader.Name }, value: { xmlReader.Value }");
//}
//var rand = new Random();

//var test = Enumerable.Range(0, 100).Select(x => new SomeClass
//{
//Name = rand.Next(0, 1000).ToString(),
//Surname = rand.Next(0, 1000).ToString(),
//Test = rand.Next(0, 1000).ToString(),
//MMo1 = rand.Next(0, 1000).ToString(),
//Mmo2 = rand.Next(0, 1000).ToString()
//}).ToArray();

//MiniExcel.SaveAs("wololololo.xlsx", test, excelType: ExcelType.XLSX, overwriteFile: true);

//class SomeClass
//{
//    [ExcelColumn(Index = 0, Name = nameof(Name))]
//    public string Name { get; set; }

//    [ExcelColumn(Index = 0, Name = nameof(Name))]
//    public string Surname { get; set; }

//    [ExcelColumn(Index = 0, Name = nameof(Name))]
//    public string Test { get; set; }

//    [ExcelColumn(Index = 0, Name = nameof(Name))]
//    public string MMo1 { get; set; }

//    [ExcelColumn(Index = 0, Name = nameof(Name))]
//    public string Mmo2 { get; set; }

//}