namespace WinPasser.Forms
{
    partial class PasswordGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeneratorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.uppercaseBox = new System.Windows.Forms.CheckBox();
            this.lowercaseBox = new System.Windows.Forms.CheckBox();
            this.numbersBox = new System.Windows.Forms.CheckBox();
            this.underscoreBox = new System.Windows.Forms.CheckBox();
            this.minusBox = new System.Windows.Forms.CheckBox();
            this.bracketsBox = new System.Windows.Forms.CheckBox();
            this.specialCharactersBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Создать пароль";
            // 
            // uppercaseBox
            // 
            this.uppercaseBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uppercaseBox.AutoSize = true;
            this.uppercaseBox.Checked = true;
            this.uppercaseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uppercaseBox.ForeColor = System.Drawing.Color.White;
            this.uppercaseBox.Location = new System.Drawing.Point(212, 311);
            this.uppercaseBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uppercaseBox.Name = "uppercaseBox";
            this.uppercaseBox.Size = new System.Drawing.Size(215, 20);
            this.uppercaseBox.TabIndex = 3;
            this.uppercaseBox.Text = "Латинские заглавные буквы";
            this.uppercaseBox.UseVisualStyleBackColor = true;
            this.uppercaseBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // lowercaseBox
            // 
            this.lowercaseBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowercaseBox.AutoSize = true;
            this.lowercaseBox.Checked = true;
            this.lowercaseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowercaseBox.ForeColor = System.Drawing.Color.White;
            this.lowercaseBox.Location = new System.Drawing.Point(212, 337);
            this.lowercaseBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lowercaseBox.Name = "lowercaseBox";
            this.lowercaseBox.Size = new System.Drawing.Size(221, 20);
            this.lowercaseBox.TabIndex = 4;
            this.lowercaseBox.Text = "Латинские прописные буквы";
            this.lowercaseBox.UseVisualStyleBackColor = true;
            this.lowercaseBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // numbersBox
            // 
            this.numbersBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numbersBox.AutoSize = true;
            this.numbersBox.Checked = true;
            this.numbersBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbersBox.ForeColor = System.Drawing.Color.White;
            this.numbersBox.Location = new System.Drawing.Point(212, 363);
            this.numbersBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numbersBox.Name = "numbersBox";
            this.numbersBox.Size = new System.Drawing.Size(75, 20);
            this.numbersBox.TabIndex = 5;
            this.numbersBox.Text = "Цифры";
            this.numbersBox.UseVisualStyleBackColor = true;
            this.numbersBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // underscoreBox
            // 
            this.underscoreBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underscoreBox.AutoSize = true;
            this.underscoreBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underscoreBox.ForeColor = System.Drawing.Color.White;
            this.underscoreBox.Location = new System.Drawing.Point(435, 337);
            this.underscoreBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.underscoreBox.Name = "underscoreBox";
            this.underscoreBox.Size = new System.Drawing.Size(184, 20);
            this.underscoreBox.TabIndex = 8;
            this.underscoreBox.Text = "Нижнее подчёркивание";
            this.underscoreBox.UseVisualStyleBackColor = true;
            this.underscoreBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // minusBox
            // 
            this.minusBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusBox.AutoSize = true;
            this.minusBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBox.ForeColor = System.Drawing.Color.White;
            this.minusBox.Location = new System.Drawing.Point(435, 311);
            this.minusBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minusBox.Name = "minusBox";
            this.minusBox.Size = new System.Drawing.Size(70, 20);
            this.minusBox.TabIndex = 7;
            this.minusBox.Text = "Минус";
            this.minusBox.UseVisualStyleBackColor = true;
            this.minusBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // bracketsBox
            // 
            this.bracketsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bracketsBox.AutoSize = true;
            this.bracketsBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bracketsBox.ForeColor = System.Drawing.Color.White;
            this.bracketsBox.Location = new System.Drawing.Point(435, 363);
            this.bracketsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bracketsBox.Name = "bracketsBox";
            this.bracketsBox.Size = new System.Drawing.Size(74, 20);
            this.bracketsBox.TabIndex = 9;
            this.bracketsBox.Text = "Скобки";
            this.bracketsBox.UseVisualStyleBackColor = true;
            this.bracketsBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // specialCharactersBox
            // 
            this.specialCharactersBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialCharactersBox.AutoSize = true;
            this.specialCharactersBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialCharactersBox.ForeColor = System.Drawing.Color.White;
            this.specialCharactersBox.Location = new System.Drawing.Point(213, 389);
            this.specialCharactersBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.specialCharactersBox.Name = "specialCharactersBox";
            this.specialCharactersBox.Size = new System.Drawing.Size(180, 20);
            this.specialCharactersBox.TabIndex = 6;
            this.specialCharactersBox.Text = "Специальные символы";
            this.specialCharactersBox.UseVisualStyleBackColor = true;
            this.specialCharactersBox.CheckedChanged += new System.EventHandler(this.ActualizePasswordGeneratorProperties);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(213, 230);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(481, 21);
            this.passwordTextBox.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(212, 179);
            this.trackBar1.Maximum = 128;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(480, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.UpdatePasswordLength);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Длина пароля";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.Location = new System.Drawing.Point(729, 230);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(838, 480);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 27);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(693, 480);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 27);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.specialCharactersBox);
            this.Controls.Add(this.bracketsBox);
            this.Controls.Add(this.minusBox);
            this.Controls.Add(this.underscoreBox);
            this.Controls.Add(this.numbersBox);
            this.Controls.Add(this.lowercaseBox);
            this.Controls.Add(this.uppercaseBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordGeneratorForm";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox uppercaseBox;
        private System.Windows.Forms.CheckBox lowercaseBox;
        private System.Windows.Forms.CheckBox numbersBox;
        private System.Windows.Forms.CheckBox underscoreBox;
        private System.Windows.Forms.CheckBox minusBox;
        private System.Windows.Forms.CheckBox bracketsBox;
        private System.Windows.Forms.CheckBox specialCharactersBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}