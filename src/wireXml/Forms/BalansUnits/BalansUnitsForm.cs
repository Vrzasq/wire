using MiniExcelLibs;
using MiniExcelLibs.Attributes;
using System.ComponentModel;

namespace wireXml.Forms.BalansUnits;

public partial class BalansUnitsForm : Form
{
    public record BalanceUnit
    {
        [ExcelColumn(Index = 0, Name = nameof(JB))]
        public string? JB { get; set; } = string.Empty;

        [ExcelColumnIndex(1)]
        [ExcelColumnName(nameof(OR))]
        public string? OR { get; set; } = string.Empty;

        [ExcelColumnIndex(2)]
        [ExcelColumnName(nameof(POB))]
        public string? POB { get; set; }
    }

    private const string BalanceUnitsFile = "balance_units";
    private readonly List<BalanceUnit> _balanceUnits = new();

    public IEnumerable<BalanceUnit> BalanceUnits => _balanceUnits;

    public BalansUnitsForm()
    {
        InitializeComponent();

        _balanceUnits.AddRange(MiniExcel
            .Query<BalanceUnit>("balance_units", excelType: ExcelType.XLSX)
            .ToArray());

        _gridBalanceUnits.DataSource = new BindingList<BalanceUnit>(BalanceUnits.ToList());
        _gridBalanceUnits.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        var columntWidth = (_gridBalanceUnits.Width - _gridBalanceUnits.RowHeadersWidth) / 3;
        _gridBalanceUnits.Columns[0].Width = columntWidth;
        _gridBalanceUnits.Columns[1].Width = columntWidth;
        _gridBalanceUnits.Columns[2].Width = columntWidth;
    }

    private void BalansUnitsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Hide();
        e.Cancel = true;
        _gridBalanceUnits.DataSource = new BindingList<BalanceUnit>(BalanceUnits.ToList());
        DiableEditing();
    }

    private void _btnAddJb_Click(object sender, EventArgs e) =>
        EnableEditing();

    private void _btnSave_Click(object sender, EventArgs e)
    {
        DiableEditing();

        _balanceUnits.Clear();
        _balanceUnits.AddRange(((IEnumerable<BalanceUnit>)_gridBalanceUnits.DataSource).ToArray());
        MiniExcel.SaveAs(BalanceUnitsFile, BalanceUnits, excelType: ExcelType.XLSX, overwriteFile: true);
        MessageBox.Show("Zapisano zmiany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void _btnDelete_Click(object sender, EventArgs e)
    {
        var selectedRows = _gridBalanceUnits.SelectedRows;

        for (int i = 0; i < selectedRows.Count; i++)
        {
            var selectedRow = selectedRows[i];
            ((BindingList<BalanceUnit>)_gridBalanceUnits.DataSource).RemoveAt(selectedRow.Index);
        }
    }

    private void EnableEditing()
    {
        _gridBalanceUnits.AllowUserToAddRows = true;
        _gridBalanceUnits.ReadOnly = false;
    }

    private void DiableEditing()
    {
        _gridBalanceUnits.AllowUserToAddRows = false;
        _gridBalanceUnits.ReadOnly = true;
    }
}
