using MyBloodAppLogin.BLL;
using MyBloodAppLogin.Cek_Stock;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.EventList;
using MyBloodAppLogin.Settings;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace MyBloodAppLogin.Homepage
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Dashboard: Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void MainVolunteer_Click(object sender, RoutedEventArgs e)
        {
            Event_List volunteer = new Event_List();
            volunteer.Show();
            this.Close();
        }

        private void MainEvent_Click(object sender, RoutedEventArgs e)
        {
            Daftar_Event1 dafEvent = new Daftar_Event1();

            // Menampilkan SecondWindow
            dafEvent.Show();

            // Menutup MainWindow (opsional, tergantung pada kebutuhan)
            this.Close();
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

        private void MyEvent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListEventWidget_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
