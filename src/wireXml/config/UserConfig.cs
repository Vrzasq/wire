namespace wireXml.config;

internal class UserConfig
{
    public const string FileName = "userConfig.json";

    public required string InputFile { get; set; }
    public required string OutputDirectrory { get; set; }
    public required string DocumentType { get; set; }
}
