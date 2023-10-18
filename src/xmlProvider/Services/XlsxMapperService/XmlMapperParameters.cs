using xmlProvider;

namespace xmlObjectProvider.Services.XlsxMapperService;

public record XmlMapperParameters(
    IEnumerable<XlsxFileInfo> XslxFileInfos,
    XmlObjectType XmlObjectType,
    BusinessParameters BusinessParameters);

public record XlsxFileInfo(
    string XlsxPath,
    string FileName);

/// <summary>
/// Business parameters
/// </summary>
/// <param name="IDOT">Numer telefonu zgłaszającego</param>
/// <param name="W">Numer porządkowy dokumentu</param>
public record BusinessParameters(
    int W,
    string IDOT,
    string KBOP,
    string KO);
