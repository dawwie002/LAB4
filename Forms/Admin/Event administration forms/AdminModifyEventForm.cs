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
    public partial class AdminModifyEventForm : Form
    {
        public AdminModifyEventForm()
        {
            InitializeComponent();
        }

        private void AdminModifyEventForm_Load(object sender, EventArgs e)
        {
            MySqlController.getEventsNames(pickEventComboBox);
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if ((eventNameTextBox.Text != String.Empty) && (eventDescriptionRTextBox.Text != String.Empty))
            {
                string Name = eventNameTextBox.Text;
                string Description = eventDescriptionRTextBox.Text;
                DateTime Date = eventDatePicker.Value.Date + eventTimePicker.Value.TimeOfDay;

                if (MySqlController.updateEventInDatabase(pickEventComboBox.Text, Name, Description, Date)) 
                {
                    MessageBox.Show("Edycja wydarzenia powiodła się.", "Sukces");
                }
                else
                {
                    MessageBox.Show("Edycja wydarzenia nie powiodła się.\r\nSpróbuj ponownie.", "Błąd");
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd");
            }
        }
    }
}
