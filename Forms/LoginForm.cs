using Lab4.Forms;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void regLink_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationWindow = new RegistrationForm();
            registrationWindow.Show();
        }

        private void showPassButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                passTextBox.PasswordChar = '\0';//pokazanie has³a
            }
            else
            {
                passTextBox.PasswordChar = '*';//ustawienie znaku maskuj¹cego na '*'
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(MySqlController.readAccountFromDatabase(loginTextBox.Text, passTextBox.Text))
            {
                if (User.IsAdmin == 1)
                {
                    AdminPanelForm adminPanel = new AdminPanelForm();
                    adminPanel.FormClosed += (s, args) =>
                    {
                        this.Show(); // Pokazuje ponownie formularz logowania po zamkniêciu panelu administratora
                    };
                    this.Hide(); // Ukrywa formularz logowania
                    adminPanel.Show();
                }
                else
                {
                    UserPanelForm userPanel = new UserPanelForm();
                    userPanel.FormClosed += (s, args) =>
                    {
                        this.Show(); // Pokazuje ponownie formularz logowania po zamkniêciu panelu u¿ytkownika
                    };
                    this.Hide(); // Ukrywa formularz logowania
                    userPanel.Show();
                }
            }
        }
    }
}
