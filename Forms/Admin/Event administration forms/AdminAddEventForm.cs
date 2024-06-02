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
    public partial class AdminAddEventForm : Form
    {
        public AdminAddEventForm()
        {
            InitializeComponent();
        }

        private void AdminAddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if ((eventNameTextBox.Text != String.Empty) && (eventDescriptionRTextBox.Text != String.Empty))
            {
                Event.Name = eventNameTextBox.Text;
                Event.Description = eventDescriptionRTextBox.Text;
                Event.Date = eventDatePicker.Value.Date + eventTimePicker.Value.TimeOfDay;
                if(MySqlController.addEventToDatabase(Event.Name, Event.Description, Event.Date))
                {
                    MessageBox.Show("Pomyślnie dodano wydarzenie.", "Sukces");
                }
                else
                {
                    MessageBox.Show("Nie udało się dodać wydarzenia.", "Błąd");
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola i spróbuj ponownie.", "Błąd");
            }
        }
    }
}
