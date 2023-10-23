using System.Text.Json;
using wireXml.config;
using xmlObjectProvider.Services.XlsxMapperService;
using xmlProvider;

namespace wireXml
{
    public partial class MainWindow : Form
    {
        private readonly IXlsxToXmlMapper _xlsxToXmlMapper;
        private readonly XmlObjectType _selectedDocumentType = XmlObjectType.ZUSE;

        public MainWindow(IXlsxToXmlMapper xlsxToXmlMapper)
        {
            _xlsxToXmlMapper = xlsxToXmlMapper;
            InitializeComponent();
            LoadDefaults();
            _txtBoxInput.TextChanged += _txtBoxInput_TextChanged;
            _txtBoxOutput.TextChanged += _txtBoxOutput_TextChanged;
            _cbDocumentType.SelectedIndexChanged += _cbDocumentType_SelectedIndexChanged;
        }

        private void _cbDocumentType_SelectedIndexChanged(object? sender, EventArgs e) =>
            SaveUserConfig();

        private void _txtBoxInput_TextChanged(object? sender, EventArgs e) =>
            SaveUserConfig();
            
        private void _txtBoxOutput_TextChanged(object? sender, EventArgs e) =>
            SaveUserConfig();

        private void _btnInput_Click(object sender, EventArgs e)
        {
            using var fileFialog = new OpenFileDialog();
            fileFialog.CheckFileExists = true;
            fileFialog.Multiselect = true;
            fileFialog.Title = $"Wybierze plik lub pliki dokumentu {_cbDocumentType.SelectedItem}";
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

            var fileInfos = _txtBoxInput.Lines.Select(x => new XlsxFileInfo(x, new FileInfo(x).Name)).ToArray();

            var businessParams = new BusinessParameters(
                W: documentVersionNumeric.Value,
                IDOT: _cbPhone.SelectedText,
                KPOB: "PO_TESTOWY00001",
                KO: "OR_TEST0001");

            var parameters = new XmlMapperParameters(
                XlsxFileInfos: fileInfos,
                XmlObjectType: (XmlObjectType)_cbDocumentType.SelectedItem,
                BusinessParameters: businessParams);

            await foreach (var xml in _xlsxToXmlMapper.GetXmlsAsync(parameters))
            {
                string file = Path.Combine(_txtBoxOutput.Text, xml.FileName);
                await File.WriteAllTextAsync(file, xml.Content);
            }

            MessageBox.Show($"Operacja zakoñczona powodzeniem", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveUserConfig()
        {
            var config = new UserConfig
            {
                DocumentType = (XmlObjectType)_cbDocumentType.SelectedItem,
                InputFile = _txtBoxInput.Text,
                OutputDirectrory = _txtBoxOutput.Text
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
            _cbDocumentType.Items.AddRange(XmlObjectType.GetAll().OrderBy(x => x.Id).ToArray());
            _cbDocumentType.SelectedIndex = _cbDocumentType.Items.IndexOf(_selectedDocumentType);
            documentVersionNumeric.Value = 1m;
            _cbStandardversion.SelectedIndex = 0;
            _cbMarketOperator.SelectedIndex = 0;
            _cbTechnicalOperator.SelectedIndex = 0;

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
            _cbDocumentType.SelectedItem = (XmlObjectType)userConfig.DocumentType;
        }
    }
}