namespace WinPasser
{
    partial class LoginForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Json-база|*.json";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(257, 281);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(351, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(257, 248);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 30);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Пароль";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFileButton.AutoSize = true;
            this.selectFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.selectFileButton.Location = new System.Drawing.Point(485, 225);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(123, 23);
            this.selectFileButton.TabIndex = 9;
            this.selectFileButton.Text = "Выбрать";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.White;
            this.fileLabel.Location = new System.Drawing.Point(257, 185);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(66, 30);
            this.fileLabel.TabIndex = 10;
            this.fileLabel.Text = "Файл";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(257, 307);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(134, 21);
            this.showPasswordCheckBox.TabIndex = 11;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.AutoSize = true;
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.acceptButton.Location = new System.Drawing.Point(257, 334);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(351, 29);
            this.acceptButton.TabIndex = 12;
            this.acceptButton.Text = "ОК";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileTextBox.Location = new System.Drawing.Point(257, 225);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(222, 20);
            this.fileTextBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileLabel);
            this.panel1.Controls.Add(this.fileTextBox);
            this.panel1.Controls.Add(this.selectFileButton);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.showPasswordCheckBox);
            this.panel1.Controls.Add(this.acceptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 607);
            this.panel1.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(887, 607);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}

