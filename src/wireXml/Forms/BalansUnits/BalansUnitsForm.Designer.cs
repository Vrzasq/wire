namespace wireXml.Forms.BalansUnits
{
    partial class BalansUnitsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly DataGridView _grid = new();

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
            SuspendLayout();
            // 
            // BalansUnitsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BalansUnitsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Jednostki bilansujace";
            FormClosing += BalansUnitsForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion
    }
}