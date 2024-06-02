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
    public partial class AdminRemoveUserForm : Form
    {
        public AdminRemoveUserForm()
        {
            InitializeComponent();
        }
        private void AdminRemoveUserForm_Load(object sender, EventArgs e)
        {
            MySqlController.getUserIDS(pickUserComboBox);
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pickUserComboBox.Text))
            {
                if (MySqlController.isThereARecordLikeThat(int.Parse(pickUserComboBox.Text),"", "ACCOUNT"))
                {
                    if (MySqlController.removeUserFromDatabase(int.Parse(pickUserComboBox.Text)))
                    {
                        MessageBox.Show("Usuwanie użytkownika zakończone powodzeniem.", "Sukces");
                    }
                    else
                    {
                        MessageBox.Show("Usuwanie użytkownika nie powiodło się.\r\nSpróbuj ponownie..", "Błąd");
                    }
                }
                else
                {
                    MessageBox.Show("Wybrany użytkownik nie istnieje.", "Błąd");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego użytkownika.", "Błąd");
            }
        }
    }
}

