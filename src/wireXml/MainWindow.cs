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
            documentType.Items.AddRange(XmlObjectType.GetAll().OrderBy(x => x.Id).ToArray());
            documentType.SelectedIndex = documentType.Items.IndexOf(_selectedDocumentType);
            documentVersionNumeric.Value = 1m;
        }

        private void _btnInput_Click(object sender, EventArgs e)
        {
            using var fileFialog = new OpenFileDialog();
            fileFialog.CheckFileExists = true;
            fileFialog.Multiselect = true;
            fileFialog.Title = $"Wybierze plik lub pliki dokumentu {documentType.SelectedItem}";
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
                MessageBox.Show("Nele¿y uzupe³niæ pliki wejœciowe i katalog docelowy", "Brak danych wejœciowych", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                XmlObjectType: (XmlObjectType)documentType.SelectedItem,
                BusinessParameters: businessParams);

            await foreach (var xml in _xlsxToXmlMapper.GetXmlsAsync(parameters))
            {
                string file = Path.Combine(_txtBoxOutput.Text, xml.FileName);
                await File.WriteAllTextAsync(file, xml.Content);
            }

            MessageBox.Show($"Operacja zakoñczona powodzeniem", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}