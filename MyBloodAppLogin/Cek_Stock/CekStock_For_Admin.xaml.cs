using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.EventList;
using MyBloodAppLogin.Homepage;
using MyBloodAppLogin.Settings;
using MyBloodAppLogin.Cek_Stock;
using System.ComponentModel;
using System.Data;

namespace MyBloodAppLogin.Cek_Stock
{
    /// <summary>
    /// Interaction logic for CekStock_For_Admin.xaml
    /// </summary>
    public partial class CekStock_For_Admin : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DataTable _dataDarah;

        public DataTable DataDarah
        {
            get { return _dataDarah; }
            set
            {
                if (_dataDarah != value)
                {
                    _dataDarah = value;
                    OnPropertyChanged(nameof(DataDarah));
                }
            }
        }

        public CekStock_For_Admin()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void boxHospital_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (boxHospital.SelectedItem != null)
            {
                string hospitalName = boxHospital.SelectedItem.ToString();
                DataDarah = GetDataByHospitalName(hospitalName);
            }
        }

        private DataTable GetDataByHospitalName(string hospitalName)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = "Data Source = EKARAHMADI\\SQLEXPRESS; Database=kantongdarah;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM hospitalTable WHERE hospitalName = @HospitalName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HospitalName", hospitalName);

                        using (SqlDataAdapter sda = new SqlDataAdapter(command))
                        {
                            sda.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return dataTable;
        }

        private string _a;
        public string A
        {
            get { return _a; }
            set
            {
                if (_a != value)
                {
                    _a = value;
                    OnPropertyChanged(nameof(A));
                }
            }
        }

        private string _b;
        public string B
        {
            get { return _b; }
            set
            {
                if (_b != value)
                {
                    _b = value;
                    OnPropertyChanged(nameof(B));
                }
            }
        }

        private string _ab;
        public string AB
        {
            get { return _ab; }
            set
            {
                if (_ab != value)
                {
                    _ab = value;
                    OnPropertyChanged(nameof(AB));
                }
            }
        }

        private string _o;
        public string O
        {
            get { return _o; }
            set
            {
                if (_o != value)
                {
                    _o = value;
                    OnPropertyChanged(nameof(O));
                }
            }
        }


        private void generateBlood()
        {
            if (DataDarah != null && DataDarah.Rows.Count > 0)
            {
                A = DataDarah.Rows[0]["A"].ToString();
                B = DataDarah.Rows[0]["B"].ToString();
                AB = DataDarah.Rows[0]["AB"].ToString();
                O = DataDarah.Rows[0]["O"].ToString();
            }
            else
            {
               
               MessageBox.Show("No data available");
            }
        }

        private void RefreshButton(object sender, RoutedEventArgs e)
        {
            generateBlood();
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            string selectedHospital = (boxHospital.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (!string.IsNullOrEmpty(selectedHospital) &&
                !string.IsNullOrEmpty(UpdateGoldarA.Text) &&
                !string.IsNullOrEmpty(UpdateGoldarB.Text) &&
                !string.IsNullOrEmpty(UpdateGoldarAB.Text) &&
                !string.IsNullOrEmpty(UpdateGoldarO.Text))
            {
                UpdateStock(selectedHospital, UpdateGoldarA.Text, UpdateGoldarB.Text, UpdateGoldarAB.Text, UpdateGoldarO.Text);
            }
            else
            {
                MessageBox.Show("Please fill in all update values and select a hospital.");
            }
        }

        private void UpdateStock(string hospitalName, string updateGoldarA, string updateGoldarB, string updateGoldarAB, string updateGoldarO)
        {
            try
            {
                string connectionString = "Data Source = EKARAHMADI\\SQLEXPRESS; Database=kantongdarah;Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE hospitalTable SET A = @UpdateGoldarA, " +
                                   "B = @UpdateGoldarB, " +
                                   "AB = @UpdateGoldarAB, " +
                                   "O = @UpdateGoldarO " +
                                   "WHERE hospitalName = @HospitalName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UpdateGoldarA", updateGoldarA);
                        command.Parameters.AddWithValue("@UpdateGoldarB", updateGoldarB);
                        command.Parameters.AddWithValue("@UpdateGoldarAB", updateGoldarAB);
                        command.Parameters.AddWithValue("@UpdateGoldarO", updateGoldarO);
                        command.Parameters.AddWithValue("@HospitalName", hospitalName);

                        command.ExecuteNonQuery();
                    }
                }

                DataDarah = GetDataByHospitalName(hospitalName); // Refresh data setelah update
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        //DOCKBAR Navigation
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Dashboard homepage = new Dashboard();

            // Menampilkan SecondWindow
            homepage.Show();

            // Menutup MainWindow (opsional, tergantung pada kebutuhan)
            this.Close();
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage settings = new SettingsPage();

            // Menampilkan SecondWindow
            settings.Show();

            // Menutup MainWindow (opsional, tergantung pada kebutuhan)
            this.Close();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            Event_List volunteer = new Event_List();

            // Menampilkan SecondWindow
            volunteer.Show();

            // Menutup MainWindow (opsional, tergantung pada kebutuhan)
            this.Close();
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            Daftar_Event1 dafEvent = new Daftar_Event1();

            // Menampilkan SecondWindow
            dafEvent.Show();

            // Menutup MainWindow (opsional, tergantung pada kebutuhan)
            this.Close();
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            CekStock_For_Check cekStok = new CekStock_For_Check();

            // Menampilkan SecondWindow
            cekStok.Show();

            // Menutup MainWindow (opsional, tergantung pada kebutuhan)
            this.Close();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginPage = new MainWindow();
            loginPage.Show();
            this.Close();
        }
    }

          
}
