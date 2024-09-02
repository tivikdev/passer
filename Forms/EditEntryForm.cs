using System;
using System.Windows.Forms;
using WinPasser.Scripts;

namespace WinPasser.Forms
{
    public partial class EditEntryForm : Form
    {
        private readonly Entry activeEntry;

        public EditEntryForm()
        {
            InitializeComponent();
            activeEntry = DataBank.ActiveEntry;
            if (activeEntry != null)
            {
                FillEntryData();
            }
        }

        private void FillEntryData()
        {
            titleTextBox.Text = activeEntry.Title;
            loginTextBox.Text = activeEntry.Login;
            passwordTextBox.Text = activeEntry.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = Generate.Password();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form currentForm = Form.ActiveForm;
            currentForm.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            activeEntry.Title = titleTextBox.Text;
            activeEntry.Login = loginTextBox.Text;
            activeEntry.Password = passwordTextBox.Text;

            DataBank.ActiveEntry = activeEntry;

            ActiveForm.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowPassword.ToggleButton(passwordTextBox);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
