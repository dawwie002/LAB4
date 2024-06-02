using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Forms.Admin
{
    public partial class AdminResetUserPasswordForm : Form
    {
        public AdminResetUserPasswordForm()
        {
            InitializeComponent();
        }

        private void AdminResetUserPasswordForm_Load(object sender, EventArgs e)
        {
            MySqlController.getUserIDS(pickUserComboBox);
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pickUserComboBox.Text))
            {
                if (MySqlController.isThereARecordLikeThat(int.Parse(pickUserComboBox.Text),"", "ACCOUNT"))
                {
                    if (newUserPassword.Text != string.Empty)
                    {
                        if (newUserPassword.Text == repeatNewUserPassword.Text)
                        {
                            MySqlController.changeUserPassword(int.Parse(pickUserComboBox.Text), newUserPassword.Text);
                            MessageBox.Show("Hasło zostało poprawnie zmienione", "Sukces");

                        }
                        else
                        {
                            MessageBox.Show("Hasła nie są identyczne.", "Błąd");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wypełnij wszystkie pola.", "Błąd");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano użytkownika.", "Błąd");
            }
        }
    }
}
