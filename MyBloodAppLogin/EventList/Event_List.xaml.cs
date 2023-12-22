using MyBloodAppLogin.BLL;
using MyBloodAppLogin.DAL;
using MyBloodAppLogin.Cek_Stock;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.Homepage;
using MyBloodAppLogin.Settings;
using MyBloodAppLogin.EventList;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace MyBloodAppLogin.EventList
{
    /// <summary>
    /// Interaction logic for List_Event.xaml
    /// </summary>
    public partial class Event_List : Window
    {
        public Event_List()
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

        public void GenerateDynamicUserControl()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Clear();
            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetEventItem();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        UC_EventListxaml listItem = new UC_EventListxaml();
                        listItem.DataContext = new EventModel
                        {
                        Event_Name = dt.Rows[i]["eventName"].ToString(),
                        Text_Date = dt.Rows[i]["date"].ToString(),
                        Text_Clock = dt.Rows[i]["time"].ToString(),
                        Text_Location = dt.Rows[i]["location"].ToString(),
                        Text_Kuota = dt.Rows[i]["quota"].ToString(),
                        Text_Telepon = dt.Rows[i]["notelp"].ToString()
                        };

                        stackPanel.Children.Add(listItem);
                    }
                }
            }
            DynamicStack.Children.Clear();
            DynamicStack.Children.Add(stackPanel);
        }

        private void RefreshButton(object sender, RoutedEventArgs e)
        {
            GenerateDynamicUserControl();
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
            GenerateDynamicUserControl();

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

    }


}
