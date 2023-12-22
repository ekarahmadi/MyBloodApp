using MaterialDesignThemes.Wpf;
using MongoDB.Driver.Core.Configuration;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.EventList;
using MyBloodAppLogin.Homepage;
using MyBloodAppLogin.Settings;
using MyBloodAppLogin.Cek_Stock;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyBloodAppLogin.BLL;
using MyBloodAppLogin.DAL;

namespace MyBloodAppLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public bool AuthenticateUser(string enteredEmail, string enteredPassword)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                DataTable userTable = objdal.ReadUserTable();

                if (userTable != null && userTable.Rows.Count > 0)
                {
                    DataRow[] foundRows = userTable.Select($"email = '{enteredEmail}'");

                    if (foundRows.Length > 0)
                    {
                        string storedPassword = foundRows[0]["password"].ToString();
                        string username = foundRows[0]["email"].ToString();
                        if (storedPassword == enteredPassword)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show($"GAGAL, MOHON CEK DAN ULANG KEMBALI. Error: {e.Message}");
                return false;
            }
        }

        private void NoAccount_Click(object sender, RoutedEventArgs e)
        {
            Page1 register = new Page1();
            register.Show();
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Mendapatkan nilai dari TextBox dan PasswordBox
                string enteredEmail = txtEmailAddress.Text;
                string enteredPassword = txtPassword.Password;

                //Menyimapn nilai email ke properti EnteredEmail pada kelas App
                ((App)Application.Current).EnteredEmail = enteredEmail;

                if (enteredEmail=="admin" && enteredPassword == "admin") {
                    CekStock_For_Admin adminPage = new CekStock_For_Admin();
                    adminPage.Show();
                    this.Close();
                }
                else
                {
                    if (AuthenticateUser(enteredEmail, enteredPassword))
                    {
                        Dashboard homepage = new Dashboard();
                        homepage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("GAGAL, MOHON CEK DAN ULANG KEMBALI");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GAGAL, MOHON CEK DAN ULANG KEMBALI. Error: {ex.Message}");
            }

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public string getEmail()
        {
            string email = txtEmailAddress.Text;
            return email;
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

       
    }

}