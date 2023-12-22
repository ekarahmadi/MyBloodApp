using System.Data.SqlClient;
using System.Windows;

namespace MyBloodAppLogin
{
    public partial class App : Application
    {
        private string enteredEmail;
        private string userDisplayName;

        public string EnteredEmail
        {
            get { return enteredEmail; }
            set
            {
                if (enteredEmail != value)
                {
                    enteredEmail = value;
                    DisplayName(); // Panggil metode DisplayName saat EnteredEmail berubah
                }
            }
        }

        public string UserDisplayName
        {
            get { return userDisplayName; }
            set
            {
                if (userDisplayName != value)
                {
                    userDisplayName = value;
                }
            }
        }

        public void DisplayName()
        {
            string connectionString = "Data Source = EKARAHMADI\\SQLEXPRESS; Database=kantongdarah;Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name FROM userTable WHERE email=@email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", EnteredEmail);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Mengambil nilai nama dari hasil query
                            UserDisplayName = reader["name"].ToString();
                        }
                        else
                        {
                            // Handle jika tidak ada baris yang sesuai dengan email
                            UserDisplayName = "User not Found";
                        }
                    }
                }
            }
        }
    }
}
