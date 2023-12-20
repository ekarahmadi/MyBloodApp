using MaterialDesignThemes.Wpf;
using MongoDB.Driver.Core.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyBloodAppLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string connectionString = @"Data Source=EKARAHMADI\SQLEXPRESS;Database=myBloodLogReg;Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NoAccount_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("\\Settings\\SettingsPage.xaml", UriKind.Relative));
            //mainFrame = Close;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conLog = new SqlConnection(connectionString))
                {
                    conLog.Open();
                    string query = "SELECT COUNT(1) FROM [user] WHERE emailUser=@emailUser AND passwordUser=@passwordUser";

                    using (SqlCommand cmdLog = new SqlCommand(query, conLog))
                    {
                        cmdLog.CommandType = CommandType.Text;
                        cmdLog.Parameters.AddWithValue("@emailUser", txtEmailAddress.Text);
                        cmdLog.Parameters.AddWithValue("@passwordUser", txtPassword.Password);

                        int count = Convert.ToInt32(cmdLog.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Email or Password is incorrect");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ImageBrush_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void txtEmailAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //DOCKBAR Navigation
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("CekStock_For_Check.xaml", UriKind.Relative));
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("\\Settings\\SettingsPage.xaml", UriKind.Relative));
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("\\Cek_Stock\\CekStock_For_Check.xaml", UriKind.Relative));
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("\\Daftar Voulenteer\\List_Event.xaml", UriKind.Relative));
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("\\Daftar Event\\Daftar_Event1.xaml", UriKind.Relative));
        }

       
    }

}