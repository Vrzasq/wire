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
            _btnStandard = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)_numDdocumentVersion).BeginInit();
            SuspendLayout();
            // 
            // _numDdocumentVersion
            // 
            _numDdocumentVersion.Location = new Point(537, 72);
            _numDdocumentVersion.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _numDdocumentVersion.Name = "_numDdocumentVersion";
            _numDdocumentVersion.Size = new Size(267, 27);
            _numDdocumentVersion.TabIndex = 4;
            _numDdocumentVersion.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 74);
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
            // 
            // _rbZUSE
            // 
            _rbZUSE.AutoSize = true;
            _rbZUSE.Location = new Point(537, 25);
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
            _rbZUSEB.Location = new Point(608, 25);
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
            _rbZGWM.Location = new Point(688, 25);
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
            _rbZOEB.Location = new Point(770, 25);
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
            _rbZOMB.Location = new Point(843, 25);
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
            _rbZOPMB.Location = new Point(921, 25);
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
            _rbZOT.Location = new Point(1007, 25);
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
            _rbZPP.Location = new Point(1070, 25);
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
            _lblChooseDocumentType.Location = new Point(256, 25);
            _lblChooseDocumentType.Name = "_lblChooseDocumentType";
            _lblChooseDocumentType.Size = new Size(167, 20);
            _lblChooseDocumentType.TabIndex = 7;
            _lblChooseDocumentType.Text = "Wybierz typ dokumentu";
            // 
            // _btnStandard
            // 
            _btnStandard.Location = new Point(33, 54);
            _btnStandard.Name = "_btnStandard";
            _btnStandard.Size = new Size(168, 29);
            _btnStandard.TabIndex = 14;
            _btnStandard.Text = "Podstawowe";
            _btnStandard.TextAlign = ContentAlignment.MiddleLeft;
            _btnStandard.UseVisualStyleBackColor = true;
            _btnStandard.Click += _btnStandard_Click;
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
            // button1
            // 
            button1.Location = new Point(33, 89);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 14;
            button1.Text = "Jednostki bilansowe";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 729);
            Controls.Add(button1);
            Controls.Add(_btnStandard);
            Controls.Add(_rbZPP);
            Controls.Add(_rbZOT);
            Controls.Add(_rbZOPMB);
            Controls.Add(_rbZOMB);
            Controls.Add(_rbZOEB);
            Controls.Add(_rbZGWM);
            Controls.Add(_rbZUSEB);
            Controls.Add(_rbZUSE);
            Controls.Add(textBox1);
            Controls.Add(_btnOutput);
            Controls.Add(_btnInput);
            Controls.Add(_txtBoxOutput);
            Controls.Add(_txtBoxInput);
            Controls.Add(_btnGenerateXml);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(_lblChooseDocumentType);
            Controls.Add(label8);
            Controls.Add(_numDdocumentVersion);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "InfoEngine - WIRExml";
            ((System.ComponentModel.ISupportInitialize)_numDdocumentVersion).EndInit();
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
        private Button _btnStandard;
        private Label label1;
        private Button button1;
    }
}