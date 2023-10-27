using Microsoft.Extensions.Logging;
using MiniExcelLibs;
using System.Text.Json;
using wireXml.config;
using wireXml.Forms.BalansUnits;
using wireXml.Forms.BasicData;
using xmlObjectProvider.Services.XlsxMapperService;

namespace wireXml;

public partial class MainWindow : Form
{
    private readonly IXlsxToXmlMapper _xlsxToXmlMapper;
    private readonly IEnumerable<RadioButton> _documentTypes;
    private readonly BasicDataForm _formBasicData;
    private readonly BalansUnitsForm _formBalansUnits;
    private readonly ILogger<MainWindow> _logger;

    public MainWindow(
        IXlsxToXmlMapper xlsxToXmlMapper,
        BasicDataForm basicDataForm,
        BalansUnitsForm balansUnitsForm,
        ILogger<MainWindow> logger)
    {
        _xlsxToXmlMapper = xlsxToXmlMapper;
        _formBasicData = basicDataForm;
        _formBalansUnits = balansUnitsForm;
        _logger = logger;
        InitializeComponent();
        _documentTypes = GetDocumentTypes();
        LoadDefaults();
    }

    private void _btnInput_Click(object sender, EventArgs e)
    {
        using var fileFialog = new OpenFileDialog();
        fileFialog.CheckFileExists = true;
        fileFialog.Multiselect = true;
        fileFialog.Title = $"Wybierze plik lub pliki";
        fileFialog.Filter = "Excel files|*.xlsx";

        if (fileFialog.ShowDialog(this) != DialogResult.OK)
            return;

        _txtBoxInput.Lines = fileFialog.FileNames;
    }

    private void _btnOutput_Click(object sender, EventArgs e)
    {
        using var fileFialog = new FolderBrowserDialog();
        fileFialog.Description = "Wybierz folder docelowy";

        if (fileFialog.ShowDialog(this) != DialogResult.OK)
            return;

        _txtBoxOutput.Text = fileFialog.SelectedPath;
    }

    private async void _btnGenerateXml_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_txtBoxOutput.Text)
            || _txtBoxInput.Lines.Length == 0)
        {
            MessageBox.Show("Nale¿y uzupe³niæ pliki wejœciowe i katalog docelowy", "Brak danych wejœciowych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        SaveUserConfig();
        var fileInfos = _txtBoxInput.Lines.Select(x => new XlsxFileInfo(x, new FileInfo(x).Name)).ToArray();
        var configurations = _formBalansUnits.BalanceUnits
            .Select(x => new BalanceUnitConfiguration(x.JB, x.OR, x.POB));

        var businessParams = new BusinessParameters(
            W: _numDdocumentVersion.Value,
            IDOT: _formBasicData.Model.PhoneNumber,
            OR: _formBasicData.Model.ORCode,
            BalanceUnitConfigurations: configurations);

        var parameters = new XmlMapperParameters(
            XlsxFileInfos: fileInfos,
            XmlObjectType: _documentTypes.First(x => x.Checked).Text,
            BusinessParameters: businessParams);

        try
        {
            await foreach (var xml in _xlsxToXmlMapper.GetXmlsAsync(parameters))
            {
                string file = Path.Combine(_txtBoxOutput.Text, xml.FileName);
                await File.WriteAllTextAsync(file, xml.Content);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "B³¹d", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show($"Operacja zakoñczona powodzeniem", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void SaveUserConfig()
    {
        var config = new UserConfig
        {
            DocumentType = _documentTypes.First(x => x.Checked).Text,
            InputFile = _txtBoxInput.Text,
            OutputDirectrory = _txtBoxOutput.Text,
            PhoneNumber = _formBasicData.Model.PhoneNumber,
            ORCode = _formBasicData.Model.ORCode,
        };

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        string json = JsonSerializer.Serialize(config, options);
        File.WriteAllText(UserConfig.FileName, json);
    }

    private void LoadDefaults()
    {
        _rbZUSE.Checked = true;
        _numDdocumentVersion.Value = 1m;

        var fileInfo = new FileInfo(UserConfig.FileName);

        if (fileInfo.Exists)
            LoadUserConfig(fileInfo);
    }

    private void LoadUserConfig(FileInfo userConfigFile)
    {
        string json = File.ReadAllText(userConfigFile.FullName);
        var userConfig = JsonSerializer.Deserialize<UserConfig>(json)!;

        _txtBoxInput.Text = userConfig.InputFile;
        _txtBoxOutput.Text = userConfig.OutputDirectrory;
        _formBasicData.UpdateData(new BasicDataModel(userConfig.PhoneNumber, userConfig.ORCode));
        var docType = _documentTypes.FirstOrDefault(x => x.Text == userConfig.DocumentType);
        if (docType is not null)
            docType.Checked = true;
    }

    private IEnumerable<RadioButton> GetDocumentTypes()
    {
        return new[]
        {
            _rbZGWM,
            _rbZOEB,
            _rbZOMB,
            _rbZOPMB,
            _rbZOT,
            _rbZPP,
            _rbZUSE,
            _rbZUSEB
        };
    }

    private void _btnStandard_Click(object sender, EventArgs e) =>
        _formBasicData.Show();

    private void button1_Click(object sender, EventArgs e)
    {
        _formBalansUnits.Show();
    }
}