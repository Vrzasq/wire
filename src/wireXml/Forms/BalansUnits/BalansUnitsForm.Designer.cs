namespace wireXml.Forms.BalansUnits
{
    partial class BalansUnitsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _gridBalanceUnits = new DataGridView();
            _btnAddJb = new Button();
            _btnSave = new Button();
            _btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)_gridBalanceUnits).BeginInit();
            SuspendLayout();
            // 
            // _gridBalanceUnits
            // 
            _gridBalanceUnits.AllowUserToAddRows = false;
            _gridBalanceUnits.AllowUserToDeleteRows = false;
            _gridBalanceUnits.AllowUserToResizeRows = false;
            _gridBalanceUnits.CausesValidation = false;
            _gridBalanceUnits.ColumnHeadersHeight = 29;
            _gridBalanceUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _gridBalanceUnits.EditMode = DataGridViewEditMode.EditOnKeystroke;
            _gridBalanceUnits.Location = new Point(0, 0);
            _gridBalanceUnits.Name = "_gridBalanceUnits";
            _gridBalanceUnits.ReadOnly = true;
            _gridBalanceUnits.RowHeadersWidth = 30;
            _gridBalanceUnits.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            _gridBalanceUnits.RowTemplate.Height = 29;
            _gridBalanceUnits.ScrollBars = ScrollBars.Vertical;
            _gridBalanceUnits.Size = new Size(496, 251);
            _gridBalanceUnits.TabIndex = 0;
            // 
            // _btnAddJb
            // 
            _btnAddJb.Location = new Point(12, 276);
            _btnAddJb.Name = "_btnAddJb";
            _btnAddJb.Size = new Size(119, 29);
            _btnAddJb.TabIndex = 1;
            _btnAddJb.Text = "Dodaj JB";
            _btnAddJb.UseVisualStyleBackColor = true;
            _btnAddJb.Click += _btnAddJb_Click;
            // 
            // _btnSave
            // 
            _btnSave.Location = new Point(376, 276);
            _btnSave.Name = "_btnSave";
            _btnSave.Size = new Size(120, 29);
            _btnSave.TabIndex = 1;
            _btnSave.Text = "Zapisz zmiany";
            _btnSave.UseVisualStyleBackColor = true;
            _btnSave.Click += _btnSave_Click;
            // 
            // _btnDelete
            // 
            _btnDelete.Location = new Point(536, 55);
            _btnDelete.Name = "_btnDelete";
            _btnDelete.Size = new Size(88, 29);
            _btnDelete.TabIndex = 1;
            _btnDelete.Text = "Usun";
            _btnDelete.UseVisualStyleBackColor = true;
            _btnDelete.Click += _btnDelete_Click;
            // 
            // BalansUnitsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 328);
            Controls.Add(_btnDelete);
            Controls.Add(_btnSave);
            Controls.Add(_btnAddJb);
            Controls.Add(_gridBalanceUnits);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BalansUnitsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Jednostki bilansujace";
            TopMost = true;
            FormClosing += BalansUnitsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)_gridBalanceUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _gridBalanceUnits;
        private Button _btnAddJb;
        private Button _btnSave;
        private Button _btnDelete;
    }
}