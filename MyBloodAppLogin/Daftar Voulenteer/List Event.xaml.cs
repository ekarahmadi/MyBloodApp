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

namespace MyBloodAppLogin.Daftar_Voulenteer
{
    /// <summary>
    /// Interaction logic for List_Event.xaml
    /// </summary>
    public partial class List_Event : Page
    {
        public List_Event()
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



        //DOCKBAR
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Homepage.xaml", UriKind.Relative));
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("SettingsPage.xaml", UriKind.Relative));
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("CekStock_For_Check.xaml", UriKind.Relative));
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("List Event.xaml", UriKind.Relative));
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Daftar Event1.xaml", UriKind.Relative));
        }
    }
}
