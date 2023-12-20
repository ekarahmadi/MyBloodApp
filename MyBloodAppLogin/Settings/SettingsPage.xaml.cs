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
using MyBloodAppLogin.Cek_Stock;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.Daftar_Voulenteer;
using MyBloodAppLogin.Homepage;

namespace MyBloodAppLogin.Settings
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
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
            NavigationService?.Navigate(new Uri("Homepage.xaml", UriKind.Relative));
        }



        //DOCKBAR Navigation
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("\\Homepage\\Home", UriKind.Relative));
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("\\DaftarEvent\\Dafatr_Event1", UriKind.Relative));
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("\\Daftar_Voulunteer\\List_Event", UriKind.Relative));
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("\\DaftarEvent\\Dafatr_Event1", UriKind.Relative));
        }

    }
}
