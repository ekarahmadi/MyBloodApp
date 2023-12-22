using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.EventList;
using MyBloodAppLogin.Homepage;
using MyBloodAppLogin.Settings;
using MyBloodAppLogin.Cek_Stock;
using MyBloodAppLogin.DaftarVolunteer;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace MyBloodAppLogin.Settings
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Window
    {
        public SettingsPage()
        {
            InitializeComponent();
            // Email_Setting.Text = "emailSetting();
            DataContext = this;
        }

        //MENU BAR ATAS
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        //MENU UTAMA
        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginPage = new MainWindow();
            loginPage.Show();
            this.Close();
        }

        public string emailSetting()
        {
            MainWindow emailSetting = new MainWindow();
            return emailSetting.getEmail();

        }

        //Mengambil data nilai email dari properti EnteredEmail di Class App
        private void DisplayEmail()
        {
            //Mengambil nilai email dari properti EnteredEmail pada kelas App
            string userEmail = ((App)Application.Current).EnteredEmail;
            string settingName = ((App)Application.Current).UserDisplayName;

            //Tampilkan email di UI Setting
            Email_Setting.Text = userEmail;
            Nama_Setting.Text = settingName;
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

        private void RefreshButton(object sender, RoutedEventArgs e)
        {

        }
    }
    }

