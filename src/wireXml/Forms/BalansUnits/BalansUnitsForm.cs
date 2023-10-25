using MiniExcelLibs;

namespace wireXml.Forms.BalansUnits;

public partial class BalansUnitsForm : Form
{
    record BalanceUnit(
        string JB,
        string OR,
        string? POB);

    public BalansUnitsForm()
    {
        var configuration = MiniExcel.Query("balance_units.xlsx", excelType: ExcelType.XLSX, startCell: "A2")
            .Select(row => new BalanceUnit(row.A, row.B, row.C))
            .ToArray();

        _grid.AutoSize = true;
        _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        Controls.Add(_grid);
        InitializeComponent();
        _grid.DataSource = configuration;
    }

    private void BalansUnitsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Hide();
        e.Cancel = true;
    }
}
