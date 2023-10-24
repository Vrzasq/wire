namespace wireXml.config;

internal class UserConfig
{
    public const string FileName = "user_config";

    public string InputFile { get; set; } = string.Empty;
    public string OutputDirectrory { get; set; } = string.Empty;
    public string DocumentType { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string ORCode { get; set; } = string.Empty;
}
