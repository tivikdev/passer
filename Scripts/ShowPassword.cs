using System.Windows.Forms;

namespace WinPasser.Scripts
{
    internal static class ShowPassword
    {
        internal static void ToggleCheckBox(TextBox passwordTextBox, CheckBox showPasswordCheckBox) 
            => passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;

        internal static void ToggleButton(TextBox passwordTextBox)
            => passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        
    }
}
