using System;
using System.Windows.Forms;
using WinPasser.Scripts;

namespace WinPasser
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            fileTextBox.Text = fileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword.ToggleCheckBox(passwordTextBox, showPasswordCheckBox);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DataBank.FilePath = openFileDialog1.FileName;
            DataBank.Key = CryptoTools.StringToByteArray(passwordTextBox.Text);
        }
    }
}
