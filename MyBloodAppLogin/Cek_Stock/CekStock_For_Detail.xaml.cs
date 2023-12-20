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
    public partial class CekStock_For_Detail: Page
    {
        public CekStock_For_Detail()
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
    }
}
