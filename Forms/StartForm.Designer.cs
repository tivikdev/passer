namespace WinPasser.Forms
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.CreateDatabaseButton = new System.Windows.Forms.Button();
            this.OpenDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDatabaseButton
            // 
            this.CreateDatabaseButton.Location = new System.Drawing.Point(337, 126);
            this.CreateDatabaseButton.Name = "CreateDatabaseButton";
            this.CreateDatabaseButton.Size = new System.Drawing.Size(359, 106);
            this.CreateDatabaseButton.TabIndex = 0;
            this.CreateDatabaseButton.Text = "Создать базу";
            this.CreateDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            // 
            // OpenDatabaseButton
            // 
            this.OpenDatabaseButton.Location = new System.Drawing.Point(337, 279);
            this.OpenDatabaseButton.Name = "OpenDatabaseButton";
            this.OpenDatabaseButton.Size = new System.Drawing.Size(359, 106);
            this.OpenDatabaseButton.TabIndex = 1;
            this.OpenDatabaseButton.Text = "Открыть базу";
            this.OpenDatabaseButton.UseVisualStyleBackColor = true;
            this.OpenDatabaseButton.Click += new System.EventHandler(this.OpenDatabaseButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CreateDatabaseButton);
            this.Controls.Add(this.OpenDatabaseButton);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDatabaseButton;
        private System.Windows.Forms.Button OpenDatabaseButton;
    }
}