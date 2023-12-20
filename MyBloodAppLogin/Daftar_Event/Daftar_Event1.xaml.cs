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

namespace MyBloodAppLogin.Daftar_Event
{
    /// <summary>
    /// Interaction logic for Daftar_Event1.xaml
    /// </summary>
    public partial class Daftar_Event1 : Page
    {
        public Daftar_Event1()
        {
            InitializeComponent();
        }


        //MENU BAR ATAS
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
            // Assuming this UserControl is hosted within a Window
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
        }



        
    }
}
