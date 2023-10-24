namespace wireXml.Forms.BasicData;

public partial class BasicDataForm : Form
{
    private BasicDataModel _model { get; set; } = new(string.Empty, string.Empty);

    public BasicDataForm()
    {
        InitializeComponent();
        UpdateData(_model);
    }

    internal BasicDataModel Model => _model;

    private void BasicDataForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Hide();
        e.Cancel = true;
        _model = new BasicDataModel(_txtPhoneNumber.Text, _txtORCode.Text);
    }

    internal void UpdateData(BasicDataModel model)
    {
        if (model is null)
            throw new ArgumentNullException(nameof(model));

        _model = model;

        _txtORCode.Text = model.ORCode;
        _txtPhoneNumber.Text = model.PhoneNumber;
    }
}
