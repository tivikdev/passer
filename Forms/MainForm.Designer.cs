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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.saveEntryButton = new System.Windows.Forms.Button();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.editEntryButton = new System.Windows.Forms.Button();
            this.entriesGridView = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.entriesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEntryButton.AutoSize = true;
            this.deleteEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteEntryButton.FlatAppearance.BorderSize = 0;
            this.deleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEntryButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEntryButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteEntryButton.Image")));
            this.deleteEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEntryButton.Location = new System.Drawing.Point(0, 189);
            this.deleteEntryButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.deleteEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(273, 100);
            this.deleteEntryButton.TabIndex = 1;
            this.deleteEntryButton.Text = "Удалить";
            this.deleteEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEntryButton.AutoSize = true;
            this.saveEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEntryButton.FlatAppearance.BorderSize = 0;
            this.saveEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEntryButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveEntryButton.Image = ((System.Drawing.Image)(resources.GetObject("saveEntryButton.Image")));
            this.saveEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveEntryButton.Location = new System.Drawing.Point(0, 389);
            this.saveEntryButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.saveEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(273, 100);
            this.saveEntryButton.TabIndex = 3;
            this.saveEntryButton.Text = "Сохранить";
            this.saveEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveEntryButton.UseVisualStyleBackColor = true;
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // addEntryButton
            // 
            this.addEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addEntryButton.AutoSize = true;
            this.addEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addEntryButton.FlatAppearance.BorderSize = 0;
            this.addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEntryButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEntryButton.Image = ((System.Drawing.Image)(resources.GetObject("addEntryButton.Image")));
            this.addEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEntryButton.Location = new System.Drawing.Point(0, -11);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(0);
            this.addEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.addEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(273, 100);
            this.addEntryButton.TabIndex = 0;
            this.addEntryButton.Text = "Добавить";
            this.addEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // editEntryButton
            // 
            this.editEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editEntryButton.AutoSize = true;
            this.editEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEntryButton.FlatAppearance.BorderSize = 0;
            this.editEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEntryButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEntryButton.Image = ((System.Drawing.Image)(resources.GetObject("editEntryButton.Image")));
            this.editEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editEntryButton.Location = new System.Drawing.Point(0, 89);
            this.editEntryButton.Margin = new System.Windows.Forms.Padding(0);
            this.editEntryButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.editEntryButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.editEntryButton.Name = "editEntryButton";
            this.editEntryButton.Size = new System.Drawing.Size(273, 100);
            this.editEntryButton.TabIndex = 4;
            this.editEntryButton.Text = "Редактировать";
            this.editEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editEntryButton.UseVisualStyleBackColor = true;
            this.editEntryButton.Click += new System.EventHandler(this.editEntryButton_Click);
            // 
            // entriesGridView
            // 
            this.entriesGridView.AllowUserToAddRows = false;
            this.entriesGridView.AllowUserToDeleteRows = false;
            this.entriesGridView.AllowUserToResizeRows = false;
            this.entriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entriesGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.entriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entriesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.entriesGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.entriesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.entriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.entriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.GridLogin,
            this.GridPassword});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.entriesGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.entriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.entriesGridView.GridColor = System.Drawing.Color.BlueViolet;
            this.entriesGridView.Location = new System.Drawing.Point(270, 50);
            this.entriesGridView.MultiSelect = false;
            this.entriesGridView.Name = "entriesGridView";
            this.entriesGridView.ReadOnly = true;
            this.entriesGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.entriesGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.entriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entriesGridView.ShowCellErrors = false;
            this.entriesGridView.ShowCellToolTips = false;
            this.entriesGridView.ShowEditingIcon = false;
            this.entriesGridView.ShowRowErrors = false;
            this.entriesGridView.Size = new System.Drawing.Size(880, 607);
            this.entriesGridView.TabIndex = 1;
            this.entriesGridView.TabStop = false;
            this.entriesGridView.DoubleClick += new System.EventHandler(this.entriesGridView_DoubleClick);
            // 
            // GridName
            // 
            this.GridName.HeaderText = "Название";
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            this.GridName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GridLogin
            // 
            this.GridLogin.HeaderText = "Логин";
            this.GridLogin.Name = "GridLogin";
            this.GridLogin.ReadOnly = true;
            this.GridLogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GridPassword
            // 
            this.GridPassword.HeaderText = "Пароль";
            this.GridPassword.Name = "GridPassword";
            this.GridPassword.ReadOnly = true;
            this.GridPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.copyPasswordButton);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.editEntryButton);
            this.panel1.Controls.Add(this.saveEntryButton);
            this.panel1.Controls.Add(this.deleteEntryButton);
            this.panel1.Controls.Add(this.addEntryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 607);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WinPasser.Properties.Resources.settings;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(3, 574);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 50);
            this.panel2.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "passer";
            this.saveFileDialog1.Filter = "Passer-база|*.passer|Все файлы|*.*";
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.copyPasswordButton.AutoSize = true;
            this.copyPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyPasswordButton.FlatAppearance.BorderSize = 0;
            this.copyPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPasswordButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyPasswordButton.Image = global::WinPasser.Properties.Resources.copy;
            this.copyPasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyPasswordButton.Location = new System.Drawing.Point(0, 289);
            this.copyPasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.copyPasswordButton.MaximumSize = new System.Drawing.Size(400, 100);
            this.copyPasswordButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(273, 100);
            this.copyPasswordButton.TabIndex = 8;
            this.copyPasswordButton.Text = "Копировать пароль";
            this.copyPasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyPasswordButton.UseVisualStyleBackColor = true;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Snow;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 657);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 679);
            this.Controls.Add(this.entriesGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passer - парольный менеджер";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.entriesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.DataGridView entriesGridView;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Button saveEntryButton;
        private System.Windows.Forms.Button editEntryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPassword;
        private System.Windows.Forms.Button copyPasswordButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}