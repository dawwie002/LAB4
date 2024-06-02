using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Forms.Admin.Request_administration_forms
{
    public partial class AdminRequestManagerForm : Form
    {
        public AdminRequestManagerForm()
        {
            InitializeComponent();
        }

        private void confirmRequestButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pickRequestComboBox.Text) && !string.IsNullOrEmpty(decisionComboBox.Text)) 
            {
                int decision = (decisionComboBox.Text == "Tak") ? 1 : 0;
                if (MySqlController.updateRequestDecisionInDatabase(decision))
                {
                    MessageBox.Show("Pomyślnie zapisano decyzje.", "Sukces");
                }
                else
                {
                    MessageBox.Show("Zapisanie decyzji nie powiodło się.\r\nSpróbuj ponownie.", "Błąd");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano wydarzenia lub decyzji.\r\nSpróbuj ponownie.", "Błąd");
            }
        }

        private void AdminRequestManagerForm_Load(object sender, EventArgs e)
        {
            MySqlController.getRequestIDS(pickRequestComboBox);
        }

        private void pickRequestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlController.readRequestFromDatabase(int.Parse(pickRequestComboBox.Text));
            UserNameTextBox.Text = Request.Account_Login;
            eventNameTextBox.Text = Request.Event_Name;
        }
    }
}