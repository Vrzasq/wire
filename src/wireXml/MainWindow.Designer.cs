namespace wireXml
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _numDdocumentVersion = new NumericUpDown();
            label7 = new Label();
            _btnGenerateXml = new Button();
            _txtBoxInput = new TextBox();
            _txtBoxOutput = new TextBox();
            _btnInput = new Button();
            _btnOutput = new Button();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            _rbZUSE = new RadioButton();
            _rbZUSEB = new RadioButton();
            _rbZGWM = new RadioButton();
            _rbZOEB = new RadioButton();
            _rbZOMB = new RadioButton();
            _rbZOPMB = new RadioButton();
            _rbZOT = new RadioButton();
            _rbZPP = new RadioButton();
            _lblChooseDocumentType = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            konfiguracjaToolStripMenuItem = new ToolStripMenuItem();
            podstawoweToolStripMenuItem = new ToolStripMenuItem();
            jednostkiBilansoweToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)_numDdocumentVersion).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // _numDdocumentVersion
            // 
            _numDdocumentVersion.Location = new Point(263, 58);
            _numDdocumentVersion.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _numDdocumentVersion.Name = "_numDdocumentVersion";
            _numDdocumentVersion.Size = new Size(69, 27);
            _numDdocumentVersion.TabIndex = 4;
            _numDdocumentVersion.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(251, 20);
            label7.TabIndex = 7;
            label7.Text = "Podaj numer porządkowy zgłoszenia";
            // 
            // _btnGenerateXml
            // 
            _btnGenerateXml.Location = new Point(973, 661);
            _btnGenerateXml.Name = "_btnGenerateXml";
            _btnGenerateXml.Size = new Size(116, 39);
            _btnGenerateXml.TabIndex = 8;
            _btnGenerateXml.Text = "Generuj XML";
            _btnGenerateXml.UseVisualStyleBackColor = true;
            _btnGenerateXml.Click += _btnGenerateXml_Click;
            // 
            // _txtBoxInput
            // 
            _txtBoxInput.Location = new Point(256, 179);
            _txtBoxInput.Multiline = true;
            _txtBoxInput.Name = "_txtBoxInput";
            _txtBoxInput.ReadOnly = true;
            _txtBoxInput.ScrollBars = ScrollBars.Vertical;
            _txtBoxInput.Size = new Size(756, 87);
            _txtBoxInput.TabIndex = 9;
            // 
            // _txtBoxOutput
            // 
            _txtBoxOutput.Location = new Point(256, 304);
            _txtBoxOutput.Name = "_txtBoxOutput";
            _txtBoxOutput.ReadOnly = true;
            _txtBoxOutput.Size = new Size(756, 27);
            _txtBoxOutput.TabIndex = 9;
            // 
            // _btnInput
            // 
            _btnInput.Location = new Point(1045, 178);
            _btnInput.Name = "_btnInput";
            _btnInput.Size = new Size(44, 29);
            _btnInput.TabIndex = 10;
            _btnInput.Text = "...";
            _btnInput.UseVisualStyleBackColor = true;
            _btnInput.Click += _btnInput_Click;
            // 
            // _btnOutput
            // 
            _btnOutput.Location = new Point(1045, 304);
            _btnOutput.Name = "_btnOutput";
            _btnOutput.Size = new Size(44, 29);
            _btnOutput.TabIndex = 10;
            _btnOutput.Text = "...";
            _btnOutput.UseVisualStyleBackColor = true;
            _btnOutput.Click += _btnOutput_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 156);
            label8.Name = "label8";
            label8.Size = new Size(244, 20);
            label8.TabIndex = 7;
            label8.Text = "Podaj plik z danymi w formacie xlsx";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 281);
            label9.Name = "label9";
            label9.Size = new Size(198, 20);
            label9.TabIndex = 7;
            label9.Text = "Podaj ścieżkę do zapisu XML";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 361);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(833, 283);
            textBox1.TabIndex = 11;
            textBox1.Text = "Log wykonania\r\nDev in progress";
            // 
            // _rbZUSE
            // 
            _rbZUSE.AutoSize = true;
            _rbZUSE.Location = new Point(179, 21);
            _rbZUSE.Name = "_rbZUSE";
            _rbZUSE.Size = new Size(65, 24);
            _rbZUSE.TabIndex = 12;
            _rbZUSE.TabStop = true;
            _rbZUSE.Text = "ZUSE";
            _rbZUSE.UseVisualStyleBackColor = true;
            // 
            // _rbZUSEB
            // 
            _rbZUSEB.AutoSize = true;
            _rbZUSEB.Location = new Point(250, 21);
            _rbZUSEB.Name = "_rbZUSEB";
            _rbZUSEB.Size = new Size(74, 24);
            _rbZUSEB.TabIndex = 13;
            _rbZUSEB.TabStop = true;
            _rbZUSEB.Text = "ZUSEB";
            _rbZUSEB.UseVisualStyleBackColor = true;
            // 
            // _rbZGWM
            // 
            _rbZGWM.AutoSize = true;
            _rbZGWM.Location = new Point(330, 21);
            _rbZGWM.Name = "_rbZGWM";
            _rbZGWM.Size = new Size(76, 24);
            _rbZGWM.TabIndex = 13;
            _rbZGWM.TabStop = true;
            _rbZGWM.Text = "ZGWM";
            _rbZGWM.UseVisualStyleBackColor = true;
            // 
            // _rbZOEB
            // 
            _rbZOEB.AutoSize = true;
            _rbZOEB.Location = new Point(412, 21);
            _rbZOEB.Name = "_rbZOEB";
            _rbZOEB.Size = new Size(67, 24);
            _rbZOEB.TabIndex = 13;
            _rbZOEB.TabStop = true;
            _rbZOEB.Text = "ZOEB";
            _rbZOEB.UseVisualStyleBackColor = true;
            // 
            // _rbZOMB
            // 
            _rbZOMB.AutoSize = true;
            _rbZOMB.Location = new Point(485, 21);
            _rbZOMB.Name = "_rbZOMB";
            _rbZOMB.Size = new Size(72, 24);
            _rbZOMB.TabIndex = 13;
            _rbZOMB.TabStop = true;
            _rbZOMB.Text = "ZOMB";
            _rbZOMB.UseVisualStyleBackColor = true;
            // 
            // _rbZOPMB
            // 
            _rbZOPMB.AutoSize = true;
            _rbZOPMB.Location = new Point(563, 21);
            _rbZOPMB.Name = "_rbZOPMB";
            _rbZOPMB.RightToLeft = RightToLeft.No;
            _rbZOPMB.Size = new Size(80, 24);
            _rbZOPMB.TabIndex = 13;
            _rbZOPMB.TabStop = true;
            _rbZOPMB.Text = "ZOPMB";
            _rbZOPMB.UseVisualStyleBackColor = true;
            // 
            // _rbZOT
            // 
            _rbZOT.AutoSize = true;
            _rbZOT.Location = new Point(649, 21);
            _rbZOT.Name = "_rbZOT";
            _rbZOT.Size = new Size(57, 24);
            _rbZOT.TabIndex = 13;
            _rbZOT.TabStop = true;
            _rbZOT.Text = "ZOT";
            _rbZOT.UseVisualStyleBackColor = true;
            // 
            // _rbZPP
            // 
            _rbZPP.AutoSize = true;
            _rbZPP.Location = new Point(712, 21);
            _rbZPP.Name = "_rbZPP";
            _rbZPP.Size = new Size(55, 24);
            _rbZPP.TabIndex = 13;
            _rbZPP.TabStop = true;
            _rbZPP.Text = "ZPP";
            _rbZPP.UseVisualStyleBackColor = true;
            // 
            // _lblChooseDocumentType
            // 
            _lblChooseDocumentType.AutoSize = true;
            _lblChooseDocumentType.Location = new Point(6, 23);
            _lblChooseDocumentType.Name = "_lblChooseDocumentType";
            _lblChooseDocumentType.Size = new Size(167, 20);
            _lblChooseDocumentType.TabIndex = 7;
            _lblChooseDocumentType.Text = "Wybierz typ dokumentu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 338);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 7;
            label1.Text = "Log wykonania";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { konfiguracjaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1141, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // konfiguracjaToolStripMenuItem
            // 
            konfiguracjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { podstawoweToolStripMenuItem, jednostkiBilansoweToolStripMenuItem });
            konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            konfiguracjaToolStripMenuItem.Size = new Size(107, 24);
            konfiguracjaToolStripMenuItem.Text = "Konfiguracja";
            // 
            // podstawoweToolStripMenuItem
            // 
            podstawoweToolStripMenuItem.Name = "podstawoweToolStripMenuItem";
            podstawoweToolStripMenuItem.Size = new Size(224, 26);
            podstawoweToolStripMenuItem.Text = "Podstawowe";
            podstawoweToolStripMenuItem.Click += podstawoweToolStripMenuItem_Click;
            // 
            // jednostkiBilansoweToolStripMenuItem
            // 
            jednostkiBilansoweToolStripMenuItem.Name = "jednostkiBilansoweToolStripMenuItem";
            jednostkiBilansoweToolStripMenuItem.Size = new Size(224, 26);
            jednostkiBilansoweToolStripMenuItem.Text = "Jednostki Bilansowe";
            jednostkiBilansoweToolStripMenuItem.Click += jednostkiBilansoweToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_lblChooseDocumentType);
            groupBox1.Controls.Add(_rbZPP);
            groupBox1.Controls.Add(_rbZUSE);
            groupBox1.Controls.Add(_rbZOT);
            groupBox1.Controls.Add(_rbZUSEB);
            groupBox1.Controls.Add(_rbZOPMB);
            groupBox1.Controls.Add(_rbZGWM);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(_rbZOMB);
            groupBox1.Controls.Add(_rbZOEB);
            groupBox1.Controls.Add(_numDdocumentVersion);
            groupBox1.Location = new Point(256, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 96);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 729);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(_btnOutput);
            Controls.Add(_btnInput);
            Controls.Add(_txtBoxOutput);
            Controls.Add(_txtBoxInput);
            Controls.Add(_btnGenerateXml);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "InfoEngine - WIRExml";
            ((System.ComponentModel.ISupportInitialize)_numDdocumentVersion).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown _numDdocumentVersion;
        private Label label7;
        private Button _btnGenerateXml;
        private TextBox _txtBoxInput;
        private TextBox _txtBoxOutput;
        private Button _btnInput;
        private Button _btnOutput;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private RadioButton _rbZUSE;
        private RadioButton _rbZUSEB;
        private RadioButton _rbZGWM;
        private RadioButton _rbZOEB;
        private RadioButton _rbZOMB;
        private RadioButton _rbZOPMB;
        private RadioButton _rbZOT;
        private RadioButton _rbZPP;
        private Label _lblChooseDocumentType;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private ToolStripMenuItem podstawoweToolStripMenuItem;
        private ToolStripMenuItem jednostkiBilansoweToolStripMenuItem;
        private GroupBox groupBox1;
    }
}