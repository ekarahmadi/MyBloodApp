using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.EventList;
using MyBloodAppLogin.Homepage;
using MyBloodAppLogin.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MyBloodAppLogin.Cek_Stock
{
    /// <summary>
    /// Interaction logic for CekStock_For_Detail1.xaml
    /// </summary>
    public partial class CekStock_For_Detail1 : Window
    {
        public CekStock_For_Detail1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            // If your UserControl is hosted within a Window
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // Menangani navigasi hyperlink
            if (e.Uri != null)
            {
                string url = e.Uri.AbsoluteUri;
                // Buka URL menggunakan default web browser
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                // Memberitahu sistem bahwa navigasi telah ditangani
                e.Handled = true;
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

        private void News_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Event_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Account_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Setting_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
