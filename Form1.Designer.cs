namespace GeneratePassword
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bGeneratePassword = new System.Windows.Forms.Button();
            this.textSetPassword = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbSymbolChars = new System.Windows.Forms.CheckBox();
            this.cbUppercaseChars = new System.Windows.Forms.CheckBox();
            this.cbDigitChars = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lMainName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lWarning = new System.Windows.Forms.Label();
            this.lLengthPassword = new System.Windows.Forms.Label();
            this.cbLowercaseChars = new System.Windows.Forms.CheckBox();
            this.bCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bGeneratePassword
            // 
            this.bGeneratePassword.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGeneratePassword.Location = new System.Drawing.Point(163, 24);
            this.bGeneratePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGeneratePassword.Name = "bGeneratePassword";
            this.bGeneratePassword.Size = new System.Drawing.Size(263, 72);
            this.bGeneratePassword.TabIndex = 0;
            this.bGeneratePassword.Text = "Generate Password";
            this.bGeneratePassword.UseVisualStyleBackColor = true;
            this.bGeneratePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSetPassword
            // 
            this.textSetPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSetPassword.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPassword.Location = new System.Drawing.Point(49, 106);
            this.textSetPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textSetPassword.Multiline = true;
            this.textSetPassword.Name = "textSetPassword";
            this.textSetPassword.ReadOnly = true;
            this.textSetPassword.Size = new System.Drawing.Size(490, 63);
            this.textSetPassword.TabIndex = 0;
            this.textSetPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(466, 77);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 30);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSymbolChars
            // 
            this.cbSymbolChars.AutoSize = true;
            this.cbSymbolChars.Checked = true;
            this.cbSymbolChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSymbolChars.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSymbolChars.Location = new System.Drawing.Point(24, 122);
            this.cbSymbolChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSymbolChars.Name = "cbSymbolChars";
            this.cbSymbolChars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSymbolChars.Size = new System.Drawing.Size(106, 37);
            this.cbSymbolChars.TabIndex = 2;
            this.cbSymbolChars.Text = "Symbols";
            this.cbSymbolChars.UseVisualStyleBackColor = true;
            // 
            // cbUppercaseChars
            // 
            this.cbUppercaseChars.AutoSize = true;
            this.cbUppercaseChars.Checked = true;
            this.cbUppercaseChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUppercaseChars.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUppercaseChars.Location = new System.Drawing.Point(24, 36);
            this.cbUppercaseChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUppercaseChars.Name = "cbUppercaseChars";
            this.cbUppercaseChars.Size = new System.Drawing.Size(132, 37);
            this.cbUppercaseChars.TabIndex = 3;
            this.cbUppercaseChars.Text = "Upper case";
            this.cbUppercaseChars.UseVisualStyleBackColor = true;
            // 
            // cbDigitChars
            // 
            this.cbDigitChars.AutoSize = true;
            this.cbDigitChars.Checked = true;
            this.cbDigitChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDigitChars.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDigitChars.Location = new System.Drawing.Point(24, 94);
            this.cbDigitChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDigitChars.Name = "cbDigitChars";
            this.cbDigitChars.Size = new System.Drawing.Size(113, 37);
            this.cbDigitChars.TabIndex = 4;
            this.cbDigitChars.Text = "Numbers";
            this.cbDigitChars.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lMainName);
            this.splitContainer1.Panel1.Controls.Add(this.textSetPassword);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.lWarning);
            this.splitContainer1.Panel2.Controls.Add(this.lLengthPassword);
            this.splitContainer1.Panel2.Controls.Add(this.cbLowercaseChars);
            this.splitContainer1.Panel2.Controls.Add(this.cbDigitChars);
            this.splitContainer1.Panel2.Controls.Add(this.bCopy);
            this.splitContainer1.Panel2.Controls.Add(this.cbUppercaseChars);
            this.splitContainer1.Panel2.Controls.Add(this.bGeneratePassword);
            this.splitContainer1.Panel2.Controls.Add(this.cbSymbolChars);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Size = new System.Drawing.Size(588, 400);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // lMainName
            // 
            this.lMainName.AutoSize = true;
            this.lMainName.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMainName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lMainName.Location = new System.Drawing.Point(108, 9);
            this.lMainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMainName.Name = "lMainName";
            this.lMainName.Size = new System.Drawing.Size(431, 85);
            this.lMainName.TabIndex = 6;
            this.lMainName.Text = "Generate Passsword";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWarning.ForeColor = System.Drawing.Color.Red;
            this.lWarning.Location = new System.Drawing.Point(21, 10);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(0, 16);
            this.lWarning.TabIndex = 6;
            this.lWarning.Visible = false;
            // 
            // lLengthPassword
            // 
            this.lLengthPassword.AutoSize = true;
            this.lLengthPassword.Font = new System.Drawing.Font("Agency FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLengthPassword.ForeColor = System.Drawing.Color.Black;
            this.lLengthPassword.Location = new System.Drawing.Point(457, 21);
            this.lLengthPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLengthPassword.Name = "lLengthPassword";
            this.lLengthPassword.Size = new System.Drawing.Size(115, 51);
            this.lLengthPassword.TabIndex = 3;
            this.lLengthPassword.Text = "Length ";
            // 
            // cbLowercaseChars
            // 
            this.cbLowercaseChars.AutoSize = true;
            this.cbLowercaseChars.Checked = true;
            this.cbLowercaseChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowercaseChars.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLowercaseChars.Location = new System.Drawing.Point(24, 65);
            this.cbLowercaseChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbLowercaseChars.Name = "cbLowercaseChars";
            this.cbLowercaseChars.Size = new System.Drawing.Size(133, 37);
            this.cbLowercaseChars.TabIndex = 5;
            this.cbLowercaseChars.Text = "Lower case";
            this.cbLowercaseChars.UseVisualStyleBackColor = true;
            // 
            // bCopy
            // 
            this.bCopy.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCopy.Location = new System.Drawing.Point(213, 113);
            this.bCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(153, 54);
            this.bCopy.TabIndex = 2;
            this.bCopy.Text = "Copy Password";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(588, 400);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Password";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGeneratePassword;
        private System.Windows.Forms.TextBox textSetPassword;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbSymbolChars;
        private System.Windows.Forms.CheckBox cbUppercaseChars;
        private System.Windows.Forms.CheckBox cbDigitChars;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cbLowercaseChars;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Label lLengthPassword;
        private System.Windows.Forms.Label lMainName;
        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.Button button1;
    }
}
