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
    public partial class UserPanelForm : Form
    {
        public UserPanelForm()
        {
            InitializeComponent();
        }
        private void UserPanelForm_Load (object sender, EventArgs e)
        {

            MySqlController.getEventsNames(eventComboBox);
            refreshGrid();
        }
        private void eventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventComboBox.SelectedItem != null)
            {
                string selectedValue = eventComboBox.Text;
                MySqlController.readEventFromDatabase(selectedValue);
                eventsDescriptionRTextBox.Text = Event.Description;
                eventDateTextBox.Text = Event.Date.ToString();
            }
        }
        private void submitRequestButton_Click(object sender, EventArgs e)
        {
            if ((eventComboBox.SelectedItem != null) && (participationTypeComboBox.SelectedItem != null) && (foodTypeComboBox.SelectedItem != null))
            {
                string participationType = participationTypeComboBox.Text;
                string foodType = foodTypeComboBox.Text;
                MySqlController.addRequestToDatabase(User.Id, Event.Id, participationType,foodType);
                refreshGrid();
            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste.", "Spróbuj ponownie.");
            }
        }
        private void refreshGrid()
        {
            string query = $"SELECT Event.Name AS 'Nazwa wydarzenia', Date AS 'Data wydarzenia', Participation_Type as 'Typ uczestnictwa', Food as 'Wyzywienie', " +
            $"CASE WHEN Request.isAccepted = 1 THEN 'Tak' ELSE 'Nie' END AS 'Czy zaakceptowany?' " +
            $"FROM Event JOIN Request ON Event.ID = Request.Event_ID JOIN Account ON Request.Account_ID = Account.ID " +
            $"WHERE Account.ID = {User.Id};";
            MySqlController.fillDataGrid(userRequestsDGV, query);
        }
    }
}
