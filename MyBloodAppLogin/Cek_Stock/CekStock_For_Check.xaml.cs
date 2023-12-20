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

namespace MyBloodAppLogin.Cek_Stock
{
    /// <summary>
    /// Interaction logic for CekStock_For_Check.xaml
    /// </summary>
    public partial class CekStock_For_Check : Page
    {
        public CekStock_For_Check()
        {
            InitializeComponent();
        }

        private void UC_Hospital_Preview_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UC_Hospital_Preview_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void UC_Hospital_Preview_Loaded_2(object sender, RoutedEventArgs e)
        {

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
            // Assuming this UserControl is hosted within a Window
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
        }

    }


}
