namespace Roman_Numerals
{
    partial class RomanNumerals
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
            Converter = new GroupBox();
            lblNumerals = new Label();
            lblNumber = new Label();
            btnClear = new Button();
            btnConvert = new Button();
            txtRoman = new TextBox();
            txtDecimal = new TextBox();
            Converter.SuspendLayout();
            SuspendLayout();
            // 
            // Converter
            // 
            Converter.Controls.Add(lblNumerals);
            Converter.Controls.Add(lblNumber);
            Converter.Controls.Add(btnClear);
            Converter.Controls.Add(btnConvert);
            Converter.Controls.Add(txtRoman);
            Converter.Controls.Add(txtDecimal);
            Converter.Location = new Point(12, 12);
            Converter.Name = "Converter";
            Converter.Size = new Size(300, 283);
            Converter.TabIndex = 0;
            Converter.TabStop = false;
            Converter.Text = "Converter";
            // 
            // lblNumerals
            // 
            lblNumerals.AutoSize = true;
            lblNumerals.Location = new Point(4, 155);
            lblNumerals.Name = "lblNumerals";
            lblNumerals.Size = new Size(99, 15);
            lblNumerals.TabIndex = 5;
            lblNumerals.Text = "Roman Numerals";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(6, 31);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(97, 15);
            lblNumber.TabIndex = 4;
            lblNumber.Text = "Decimal Number";
            lblNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(87, 49);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(6, 49);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvertClick;
            // 
            // txtRoman
            // 
            txtRoman.Location = new Point(6, 183);
            txtRoman.Multiline = true;
            txtRoman.Name = "txtRoman";
            txtRoman.ReadOnly = true;
            txtRoman.Size = new Size(288, 78);
            txtRoman.TabIndex = 1;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(6, 78);
            txtDecimal.Multiline = true;
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(288, 74);
            txtDecimal.TabIndex = 0;
            // 
            // RomanNumerals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 308);
            Controls.Add(Converter);
            Name = "RomanNumerals";
            ShowIcon = false;
            Text = "Roman Numerals";
            Converter.ResumeLayout(false);
            Converter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Converter;
        private Button btnConvert;
        private TextBox txtRoman;
        private TextBox txtDecimal;
        private Label lblNumerals;
        private Label lblNumber;
        private Button btnClear;
    }
}