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
