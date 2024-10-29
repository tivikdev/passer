using System;
using System.Windows.Forms;
using WinPasser.Scripts;

namespace WinPasser.Forms
{
    public partial class EditEntryForm : Form
    {
        private readonly Entry activeEntry;
        private readonly bool isCreatingEntry;

        public EditEntryForm()
        {
            InitializeComponent();
            activeEntry = DataBank.ActiveEntry;
            isCreatingEntry = DataBank.IsCreatingEntry;

            label1.Text = isCreatingEntry ? "Создание новой записи" : "Редактирование записи";
            DataBank.IsCreatingEntry = false;
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
            PasswordGeneratorForm passwordGeneratorForm = new PasswordGeneratorForm();
            if(passwordGeneratorForm.ShowDialog() == DialogResult.OK)
            {
                passwordTextBox.Text = DataBank.GeneratedPassword;
                DataBank.GeneratedPassword = string.Empty;
            }
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

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword.ToggleCheckBox(passwordTextBox, showPasswordCheckBox);
        }
    }
}
