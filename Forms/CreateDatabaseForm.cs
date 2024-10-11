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
            if (string.IsNullOrEmpty(createDatabaseDialog.FileName) || string.IsNullOrEmpty(passwordTextBox.Text))
                return;

            string plainPassword = passwordTextBox.Text;
            DataBank.FilePath = createDatabaseDialog.FileName;
            DataBank.Key = CryptoTools.StringToByteArray(plainPassword);

            DialogResult = DialogResult.OK;
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword.ToggleCheckBox(passwordTextBox, showPasswordCheckBox);
        }
    }
}
