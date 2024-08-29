namespace WinPasser
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.editEntryButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.saveEntryButton = new System.Windows.Forms.Button();
            this.entriesGridView = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.deleteEntryButton);
            this.flowLayoutPanel1.Controls.Add(this.saveEntryButton);
            this.flowLayoutPanel1.Controls.Add(this.addEntryButton);
            this.flowLayoutPanel1.Controls.Add(this.editEntryButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1134, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addEntryButton.AutoSize = true;
            this.addEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addEntryButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEntryButton.Image = global::WinPasser.Properties.Resources.plus_square;
            this.addEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEntryButton.Location = new System.Drawing.Point(570, 3);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(0);
            this.addEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.addEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(279, 100);
            this.addEntryButton.TabIndex = 0;
            this.addEntryButton.Text = "Добавить";
            this.addEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // editEntryButton
            // 
            this.editEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editEntryButton.AutoSize = true;
            this.editEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEntryButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEntryButton.Image = global::WinPasser.Properties.Resources.edit_3;
            this.editEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editEntryButton.Location = new System.Drawing.Point(852, 3);
            this.editEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.editEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.editEntryButton.Name = "editEntryButton";
            this.editEntryButton.Size = new System.Drawing.Size(279, 100);
            this.editEntryButton.TabIndex = 4;
            this.editEntryButton.Text = "Редактировать";
            this.editEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editEntryButton.UseVisualStyleBackColor = true;
            this.editEntryButton.Click += new System.EventHandler(this.editEntryButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteEntryButton.AutoSize = true;
            this.deleteEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteEntryButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEntryButton.Image = global::WinPasser.Properties.Resources.trash_2;
            this.deleteEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEntryButton.Location = new System.Drawing.Point(3, 3);
            this.deleteEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.deleteEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(279, 100);
            this.deleteEntryButton.TabIndex = 1;
            this.deleteEntryButton.Text = "Удалить";
            this.deleteEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveEntryButton.AutoSize = true;
            this.saveEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEntryButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveEntryButton.Image = global::WinPasser.Properties.Resources.save;
            this.saveEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveEntryButton.Location = new System.Drawing.Point(288, 3);
            this.saveEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.saveEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(279, 100);
            this.saveEntryButton.TabIndex = 3;
            this.saveEntryButton.Text = "Сохранить";
            this.saveEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveEntryButton.UseVisualStyleBackColor = true;
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // entriesGridView
            // 
            this.entriesGridView.AllowUserToAddRows = false;
            this.entriesGridView.AllowUserToDeleteRows = false;
            this.entriesGridView.AllowUserToResizeRows = false;
            this.entriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.GridLogin,
            this.GridPassword});
            this.entriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesGridView.Location = new System.Drawing.Point(0, 105);
            this.entriesGridView.Name = "entriesGridView";
            this.entriesGridView.ReadOnly = true;
            this.entriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entriesGridView.Size = new System.Drawing.Size(1134, 574);
            this.entriesGridView.TabIndex = 1;
            this.entriesGridView.DoubleClick += new System.EventHandler(this.entriesGridView_DoubleClick);
            // 
            // GridName
            // 
            this.GridName.HeaderText = "Имя";
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            // 
            // GridLogin
            // 
            this.GridLogin.HeaderText = "Логин";
            this.GridLogin.Name = "GridLogin";
            this.GridLogin.ReadOnly = true;
            // 
            // GridPassword
            // 
            this.GridPassword.HeaderText = "Пароль";
            this.GridPassword.Name = "GridPassword";
            this.GridPassword.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 679);
            this.Controls.Add(this.entriesGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1150, 500);
            this.Name = "MainForm";
            this.Text = "Passer - парольный менеджер";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entriesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.DataGridView entriesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPassword;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Button saveEntryButton;
        private System.Windows.Forms.Button editEntryButton;
    }
}