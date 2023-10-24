namespace wireXml.Forms.BasicData
{
    partial class BasicDataForm
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
            label1 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            _txtPhoneNumber = new TextBox();
            _txtORCode = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 41);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 9;
            label1.Text = "Kod Węzła";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "TEST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 71);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 11;
            label5.Text = "Telefon";
            // 
            // _txtPhoneNumber
            // 
            _txtPhoneNumber.Location = new Point(157, 71);
            _txtPhoneNumber.Name = "_txtPhoneNumber";
            _txtPhoneNumber.Size = new Size(269, 27);
            _txtPhoneNumber.TabIndex = 10;
            // 
            // _txtORCode
            // 
            _txtORCode.Location = new Point(157, 104);
            _txtORCode.Name = "_txtORCode";
            _txtORCode.Size = new Size(269, 27);
            _txtORCode.TabIndex = 10;
            _txtORCode.Text = "OR_OPERATOR00001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 104);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 11;
            label2.Text = "Kod OR";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 10;
            textBox3.Text = "WIRE 14.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 137);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 11;
            label3.Text = "Wersja";
            // 
            // BasicDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 190);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(_txtORCode);
            Controls.Add(_txtPhoneNumber);
            Controls.Add(label1);
            Controls.Add(textBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BasicDataForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Dane podstawowe";
            FormClosing += BasicDataForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private TextBox _txtPhoneNumber;
        private TextBox _txtORCode;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}