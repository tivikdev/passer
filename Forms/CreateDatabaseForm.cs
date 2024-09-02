using System;
using System.Windows.Forms;
using WinPasser.Scripts;

namespace WinPasser.Forms
{
    public partial class CreateDatabaseForm : Form
    {
        public CreateDatabaseForm()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (createDatabaseDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = createDatabaseDialog.FileName;
                DataBank.FilePath = createDatabaseDialog.FileName;
            }
        }

        private void createDatabaseButton_Click(object sender, EventArgs e)
        {
            string plainPassword = passwordTextBox.Text;
            if (plainPassword == string.Empty || DataBank.FilePath == null)
            {
                return;
            }

            DataBank.Key = CryptoTools.StringToByteArray(plainPassword);
        }
    }
}
