using Lab4.Forms.Admin;
using Lab4.Forms.Admin.Event_forms;
using Lab4.Forms.Admin.Request_administration_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        private void AdminPanelForm_Load(object sender, EventArgs e) { 
            refreshGrids();
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationWindow = new RegistrationForm();
            registrationWindow.Show();
        }
        private void refreshGridsButton_Click(object sender, EventArgs e)
        {
            refreshGrids();
        }
        public void refreshGrids()
        {
            //pokaz konta bez uprawnien administratora
            MySqlController.fillDataGrid(userDataGridView, "SELECT ID, NAME as Imie, SURNAME as Nazwisko, Email, Login FROM ACCOUNT WHERE isAdministrator = 0");
            //pokaz wydarzenia
            MySqlController.fillDataGrid(eventDataGridView, "SELECT ID, Name as 'Nazwa wydarzenia', Description as Agenda, Date as Data FROM EVENT");
            //pokaz requesty - zapisy
            MySqlController.fillDataGrid(requestDataGridView, "SELECT Request.ID, Account.Name AS Imie, Account.Surname AS Nazwisko, Event.Name AS 'Nazwa wydarzenia', Request.Participation_Type as 'Typ uczestnictwa', Request.Food as Wyzywienie " +
                                                            "FROM Account JOIN Request ON Account.ID = Request.Account_ID JOIN Event ON Request.Event_ID = Event.ID;");
        }
        private void removeUserButton_Click(object sender, EventArgs e)
        {
            AdminRemoveUserForm removeUserWindow = new AdminRemoveUserForm();
            removeUserWindow.Show();
        }
        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            AdminResetUserPasswordForm resetPasswordWindow = new AdminResetUserPasswordForm();
            resetPasswordWindow.Show();
        }
        private void addEventButton_Click(object sender, EventArgs e)
        {
            AdminAddEventForm addEventform = new AdminAddEventForm();
            addEventform.Show();
        }
        private void removeEventButton_Click(object sender, EventArgs e)
        {
            AdminRemoveEventForm removeWindow = new AdminRemoveEventForm();
            removeWindow.Show();
        }
        private void modifyEventButton_Click(object sender, EventArgs e)
        {
            AdminModifyEventForm editEventWindow = new AdminModifyEventForm();
            editEventWindow.Show();
        }
        private void confirmRequestButton_Click(object sender, EventArgs e)
        {
            AdminRequestManagerForm RequestWindows = new AdminRequestManagerForm();
            RequestWindows.Show();
        }
    }
}
