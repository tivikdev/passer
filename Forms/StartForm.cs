using System;
using System.Windows.Forms;

namespace WinPasser.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            using (CreateDatabaseForm createDatabase = new CreateDatabaseForm())
            {
                if (createDatabase.ShowDialog() == DialogResult.OK) 
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void OpenDatabaseButton_Click(object sender, EventArgs e)
        {
            using (LoginForm openDatabase = new LoginForm())
            {
                if (openDatabase.ShowDialog() == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
