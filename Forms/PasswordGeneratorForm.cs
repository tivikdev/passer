using System;
using System.Windows.Forms;
using WinPasser.Scripts;

namespace WinPasser.Forms
{
    public partial class PasswordGeneratorForm : Form
    {
        private PasswordGeneratorProperties properties = new PasswordGeneratorProperties();
        private string password;
        private uint passwordLength;

        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordLength(uint newLength)
        {
            maskedTextBox1.Text = newLength.ToString();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            OnLoadActualizePasswordGeneratorProperties();
            UpdatePasswordLength(sender, e);
            GeneratePasswordForTextBox(properties, passwordLength);
        }

        private void GeneratePasswordForTextBox(PasswordGeneratorProperties properties, uint passwordLength)
        {
            password = Generate.CustomizedPassword(properties, passwordLength);
            passwordTextBox.Text = password;
        }

        private void UpdatePasswordLength(object sender, EventArgs e)
        {
            passwordLength = Convert.ToUInt32(trackBar1.Value);
            OnLoadActualizePasswordGeneratorProperties();
            ChangePasswordLength(passwordLength);
            GeneratePasswordForTextBox(properties, passwordLength);
        }

        private void ActualizePasswordGeneratorProperties(object sender, EventArgs e)
        {
            OnLoadActualizePasswordGeneratorProperties();
            GeneratePasswordForTextBox(properties, passwordLength);
        }

        private void OnLoadActualizePasswordGeneratorProperties()
        {
            properties.Uppercase.Use = uppercaseBox.Checked;

            properties.Lowercase.Use = lowercaseBox.Checked;

            properties.Numbers.Use = numbersBox.Checked;

            properties.SpecialCharacters.Use = specialCharactersBox.Checked;

            properties.Minus.Use = minusBox.Checked;

            properties.Underscore.Use = underscoreBox.Checked;

            properties.Brackets.Use = bracketsBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataBank.GeneratedPassword = password;
            DialogResult = DialogResult.OK;
        }
    }
}
