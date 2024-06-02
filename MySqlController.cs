using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab4
{
    public class MySqlController
    {
        static string server = "127.0.0.1";
        static string database = "LAB4Pwsw";
        static string uid = "root";
        static string password = "";

        static string connectionPath = $"server={server}; database={database}; Uid={uid}; password={password};";

        //metody zarzadzajace kontami
        public static void addAccountToDatabase(string name, string surname, string email, string login, string password)
        {
            byte isAdmin = 0; 
            string query = "INSERT INTO ACCOUNT (Name, Surname, Email, Login, Password, isAdministrator, CreationDate) " +
                           "VALUES (@Name, @Surname, @Email, @Login, @Password, @IsAdmin, NOW())";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsAdmin", isAdmin);

                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Błąd!");
            }
        }
        public static bool readAccountFromDatabase(string login, string password)
        {
            string query = "SELECT * FROM ACCOUNT WHERE login = @Login LIMIT 1\n";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (User.FailedLoginCounter >= 3)
                    {
                        MessageBox.Show("Logowanie nie powiodło się wiecej niż 3 razy.\nSkontaktuj się z administratorem.", "Przekroczono limit prób.");
                        return false;
                    }

                    if (reader.Read())
                    {
                        User.Login = reader.GetString("Login");
                        User.Password = reader.GetString("Password");

                        if (User.Login == login && User.Password == password)
                        {
                            User.Id = reader.GetInt32("ID");
                            User.Firstname = reader.GetString("Name");
                            User.Lastname = reader.GetString("Surname");
                            User.Email = reader.GetString("Email");
                            User.IsAdmin = reader.GetByte("isAdministrator");
                            User.FailedLoginCounter = 0;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Logowanie nie powiodło się\r\nSpróbuj ponownie.", "Błąd!");
                            User.FailedLoginCounter++;
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Logowanie nie powiodło się\r\nSpróbuj ponownie.", "Błąd!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Błąd!");
            }
            return false; //jeśli konta nie znaleziono
        }
        public static bool removeUserFromDatabase(int id)
        {
            string query = @"DELETE FROM ACCOUNT WHERE ID = @id and isAdministrator = 0";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd");
            }
            return false;

        }
        public static void changeUserPassword(int id, string password)
        {
            string query = @"UPDATE Account SET Password = @password WHERE ID = @id";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd");
            }
        }
        public static void getUserIDS(ComboBox comboBox)
        {
            string query = "SELECT * FROM ACCOUNT WHERE isAdministrator = 0";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Wykonanie zapytania i pobranie wyników
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Iteracja przez wyniki zapytania
                        while (reader.Read())
                        {
                            // Pobranie wartości z kolumny i dodanie do ComboBox
                            comboBox.Items.Add(reader.GetInt16("ID"));
                        }
                    }
                }
            }
        }

        //metody zarzadzajace wydarzeniami
        public static bool addEventToDatabase(string name, string description, DateTime date)
        {
            string query = "INSERT INTO EVENT (Name, Description, Date) VALUES (@Name, @Description, @Date)";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Date", date);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Błąd!");
            }
            return false;
        }
        public static void readEventFromDatabase(string eventsName)
        {
            string query = "SELECT * FROM EVENT WHERE NAME = @eventsName";

            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@eventsName", eventsName);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Event.Id = reader.GetInt32("ID");
                    Event.Name = reader.GetString("Name");
                    Event.Description = reader.GetString("Description");
                    Event.Date = reader.GetDateTime("Date");
                }
            }
        }
        public static bool removeEventFromDatabase(string name)
        {
            string query = @"DELETE FROM Event WHERE Name = @name";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd");
            }
            return false;

        }
        public static bool updateEventInDatabase(string pickedEventName, string newName, string newDescription, DateTime newDate)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    readEventFromDatabase(pickedEventName);//zaczytanie wydarzenia
                    if(Event.Id !=0)
                    {
                        connection.Open();
                        string query = "UPDATE EVENT SET Name = @Name, Description = @Description, Date = @Date WHERE ID = @ID";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", newName);
                        command.Parameters.AddWithValue("@Description", newDescription);
                        command.Parameters.AddWithValue("@Date", newDate);
                        command.Parameters.AddWithValue("@ID", Event.Id);

                        command.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }
        public static void getEventsNames(ComboBox comboBox)
        {
            string query = "SELECT * FROM EVENT";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Wykonanie zapytania i pobranie wyników
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Iteracja przez wyniki zapytania
                        while (reader.Read())
                        {
                            // Pobranie wartości z kolumny i dodanie do ComboBox
                            comboBox.Items.Add(reader.GetString("Name"));
                        }
                    }
                }
            }
        }

        //metody zarządzające zapisami
        public static void addRequestToDatabase(int account_ID, int event_ID, string participation_Type, string food)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                string query = "INSERT INTO REQUEST (Account_ID, Event_ID, Participation_Type, Food, isAccepted) " +
                               "VALUES (@account_ID, @event_ID, @participation_Type, @food, @isAccepted)";
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Ustawianie parametrów
                    // poniższy sposób pozwala uchronić się przed atakami SQL Injection
                    command.Parameters.AddWithValue("@account_ID", account_ID);
                    command.Parameters.AddWithValue("@event_ID", event_ID);
                    command.Parameters.AddWithValue("@participation_Type", participation_Type);
                    command.Parameters.AddWithValue("@food", food);
                    command.Parameters.AddWithValue("@isAccepted", 0);

                    command.ExecuteNonQuery();

                    MessageBox.Show($"Pomyślnie zapisano na wydarzenie: {Event.Name}", "Sukces!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Błąd!");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void getRequestIDS(ComboBox comboBox)
        {
            string query = "SELECT * FROM REQUEST";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Wykonanie zapytania i pobranie wyników
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Iteracja przez wyniki zapytania
                        while (reader.Read())
                        {
                            // Pobranie wartości z kolumny i dodanie do ComboBox
                            comboBox.Items.Add(reader.GetInt16("ID"));
                        }
                    }
                }
            }
        }
        public static void readRequestFromDatabase(int requestID)
        {
            string query = "SELECT r.ID AS RequestID, a.Login AS UserLogin, e.Name AS EventName FROM Request r JOIN Account a ON r.Account_ID = a.ID JOIN Event e ON r.Event_ID = e.ID WHERE r.ID = @requestID";

            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@requestID", requestID);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Request.Id = reader.GetInt32("RequestID");
                    Request.Account_Login = reader.GetString("UserLogin");
                    Request.Event_Name = reader.GetString("EventName");
                }
            }
        }
        public static bool updateRequestDecisionInDatabase(int decision)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionPath))
                {
                    connection.Open();
                    string query = "UPDATE REQUEST SET isAccepted = @decision WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@decision", decision);
                    command.Parameters.AddWithValue("@ID", Request.Id);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }

        //inne metody
        public static bool isThereARecordLikeThat(int id, string name, string tableName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                if(tableName.ToUpper() == "EVENT")
                {
                    readEventFromDatabase(name);
                    id = Event.Id;
                }

                List<string> validTableNames = new List<string> { "EVENT", "ACCOUNT", "REQUEST"};
                if (!validTableNames.Contains(tableName.ToUpper()))
                {
                    throw new ArgumentException("Invalid table name provided.");
                }

                try
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    int rowCount = Convert.ToInt32(command.ExecuteScalar());
                    return rowCount > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                return false;
            }
        }
        public static void fillDataGrid(DataGridView datagrid, string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                MySqlDataAdapter userAdapter = new MySqlDataAdapter(query, connection);
                DataTable userDataTable = new DataTable();
                userAdapter.Fill(userDataTable);
                datagrid.DataSource = userDataTable;
            }
        }
    }
}
