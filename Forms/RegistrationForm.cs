using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(firstnameTextBox.Text) && !string.IsNullOrEmpty(lastnameTextBox.Text) && !string.IsNullOrEmpty(emailTextBox.Text) && !string.IsNullOrEmpty(loginTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                if (passwordTextBox.Text.Equals(passwordRepeatTextBox.Text))
                {
                    string name = firstnameTextBox.Text;
                    string lastname = lastnameTextBox.Text;
                    string email = emailTextBox.Text;
                    string login = loginTextBox.Text;
                    string password = passwordTextBox.Text;

                    MySqlController.addAccountToDatabase(name, lastname, email, login, password);
                    MessageBox.Show("Sukces!", "Konto zostało pomyślnie utworzone!");
                }
                else
                {
                    MessageBox.Show("Podane hasła są różne.");
                }
            }
            else
            {
                MessageBox.Show("Wypełnij poprawnie wszystkie pola.", "Błąd");
            }
        }
    }
}
