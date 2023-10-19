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
            documentVersionNumeric = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            _cbPhone = new ComboBox();
            documentType = new ComboBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            _btnGenerateXml = new Button();
            _txtBoxInput = new TextBox();
            _txtBoxOutput = new TextBox();
            _btnInput = new Button();
            _btnOutput = new Button();
            label8 = new Label();
            label9 = new Label();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)documentVersionNumeric).BeginInit();
            SuspendLayout();
            // 
            // documentVersionNumeric
            // 
            documentVersionNumeric.Location = new Point(839, 275);
            documentVersionNumeric.Name = "documentVersionNumeric";
            documentVersionNumeric.Size = new Size(267, 27);
            documentVersionNumeric.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "InfoEngine S.A." });
            comboBox1.Location = new Point(839, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "14.0" });
            comboBox2.Location = new Point(839, 173);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 28);
            comboBox2.TabIndex = 5;
            // 
            // _cbPhone
            // 
            _cbPhone.FormattingEnabled = true;
            _cbPhone.Items.AddRange(new object[] { "+48 222 333 444" });
            _cbPhone.Location = new Point(839, 207);
            _cbPhone.Name = "_cbPhone";
            _cbPhone.Size = new Size(268, 28);
            _cbPhone.TabIndex = 5;
            // 
            // documentType
            // 
            documentType.FormattingEnabled = true;
            documentType.Location = new Point(838, 241);
            documentType.Name = "documentType";
            documentType.Size = new Size(268, 28);
            documentType.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(839, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "TEST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(753, 72);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "Kod Węzła";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(724, 107);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 7;
            label2.Text = "Operator rynku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 142);
            label3.Name = "label3";
            label3.Size = new Size(214, 20);
            label3.TabIndex = 7;
            label3.Text = "Operator handlowo-techniczny";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(710, 176);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 7;
            label4.Text = "Wersja standardu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(719, 210);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 7;
            label5.Text = "Numer telefonu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(721, 244);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 7;
            label6.Text = "Typ dokumentu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(701, 277);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 7;
            label7.Text = "Wersja dokumentu";
            // 
            // _btnGenerateXml
            // 
            _btnGenerateXml.Location = new Point(374, 275);
            _btnGenerateXml.Name = "_btnGenerateXml";
            _btnGenerateXml.Size = new Size(116, 39);
            _btnGenerateXml.TabIndex = 8;
            _btnGenerateXml.Text = "Generuj XML";
            _btnGenerateXml.UseVisualStyleBackColor = true;
            _btnGenerateXml.Click += _btnGenerateXml_Click;
            // 
            // _txtBoxInput
            // 
            _txtBoxInput.Location = new Point(36, 72);
            _txtBoxInput.Multiline = true;
            _txtBoxInput.Name = "_txtBoxInput";
            _txtBoxInput.ReadOnly = true;
            _txtBoxInput.ScrollBars = ScrollBars.Vertical;
            _txtBoxInput.Size = new Size(386, 87);
            _txtBoxInput.TabIndex = 9;
            // 
            // _txtBoxOutput
            // 
            _txtBoxOutput.Location = new Point(36, 185);
            _txtBoxOutput.Name = "_txtBoxOutput";
            _txtBoxOutput.ReadOnly = true;
            _txtBoxOutput.Size = new Size(386, 27);
            _txtBoxOutput.TabIndex = 9;
            // 
            // _btnInput
            // 
            _btnInput.Location = new Point(446, 74);
            _btnInput.Name = "_btnInput";
            _btnInput.Size = new Size(44, 29);
            _btnInput.TabIndex = 10;
            _btnInput.Text = "...";
            _btnInput.UseVisualStyleBackColor = true;
            _btnInput.Click += _btnInput_Click;
            // 
            // _btnOutput
            // 
            _btnOutput.Location = new Point(446, 183);
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
            label8.Location = new Point(36, 49);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 7;
            label8.Text = "Źródło danych";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 162);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 7;
            label9.Text = "Katalog docelowy";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Operator Systemu Przesyłowego" });
            comboBox4.Location = new Point(838, 104);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(268, 28);
            comboBox4.TabIndex = 5;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 373);
            Controls.Add(_btnOutput);
            Controls.Add(_btnInput);
            Controls.Add(_txtBoxOutput);
            Controls.Add(_txtBoxInput);
            Controls.Add(_btnGenerateXml);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(documentType);
            Controls.Add(_cbPhone);
            Controls.Add(comboBox2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox1);
            Controls.Add(documentVersionNumeric);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "InfoEngine - WIRExml";
            ((System.ComponentModel.ISupportInitialize)documentVersionNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown documentVersionNumeric;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox _cbPhone;
        private ComboBox documentType;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button _btnGenerateXml;
        private TextBox _txtBoxInput;
        private TextBox _txtBoxOutput;
        private Button _btnInput;
        private Button _btnOutput;
        private Label label8;
        private Label label9;
        private ComboBox comboBox4;
    }
}