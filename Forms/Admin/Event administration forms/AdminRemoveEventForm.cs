using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Forms.Admin.Event_forms
{
    public partial class AdminRemoveEventForm : Form
    {
        public AdminRemoveEventForm()
        {
            InitializeComponent();
        }

        private void AdminRemoveEventForm_Load(object sender, EventArgs e)
        {
            MySqlController.getEventsNames(pickEventComboBox);
        }

        private void removeEventButton_Click(object sender, EventArgs e)
        {
            if (pickEventComboBox.Text != string.Empty)
            {
                if (MySqlController.isThereARecordLikeThat(0,pickEventComboBox.Text, "EVENT"))
                {
                    if (MySqlController.removeEventFromDatabase(pickEventComboBox.Text))
                    {
                        MessageBox.Show("Usuwanie wydarzenia zakończone.", "Sukces");
                    }
                    else
                    {
                        MessageBox.Show("Usuwanie wydarzenia nie powiodło się.\r\nSpróbuj ponownie.", "Błąd");
                    }
                }
                else
                {
                    MessageBox.Show("Wybrane wydarzenie nie istnieje.\r\nSpróbuj ponownie.", "Błąd");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego wydarzenia.", "Błąd!");
            }
        }
    }
}
