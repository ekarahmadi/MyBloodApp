using MyBloodAppLogin.Daftar_Voulenteer;
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

namespace MyBloodAppLogin.Homepage
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void MainVolunteer_Click(object sender, RoutedEventArgs e)
        {
            if (homepageFrame.NavigationService != null)
            {
                homepageFrame.NavigationService.Navigate(new Uri("List_Event.xaml", UriKind.Relative));
            }
        }

        private void MainEvent_Click(object sender, RoutedEventArgs e)
        {
            if (homepageFrame.NavigationService != null)
            {
                homepageFrame.NavigationService.Navigate(new Uri("List_Event.xaml", UriKind.Relative));
            }
        }
    }
}
