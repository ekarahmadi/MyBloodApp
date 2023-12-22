using MyBloodAppLogin.BLL;
using MyBloodAppLogin.Cek_Stock;
using MyBloodAppLogin.Daftar_Event;
using MyBloodAppLogin.EventList;
using MyBloodAppLogin.Homepage;
using MyBloodAppLogin.Settings;
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

namespace MyBloodAppLogin.DaftarVolunteer
{
    /// <summary>
    /// Interaction logic for FormVolunteer.xaml
    /// </summary>
    public partial class FormVolunteer : Window
    {
        public FormVolunteer()
        {
            InitializeComponent();
            DataContext = this;
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


        public static readonly DependencyProperty EventNameProperty =
        DependencyProperty.Register("Label_Event", typeof(string), typeof(FormVolunteer));

        // Property untuk mengakses nilai DependencyProperty
        public string Label_Event
        {
            get { return (string)GetValue(EventNameProperty); }
            set { SetValue(EventNameProperty, value); }
        }

        //MENU UTAMA
        private void DaftarAksi_Click(object sender, RoutedEventArgs e)
        {
            string namaPendonor = txtNamaPendonor.Text;
            string bloodType = (boxBloodType.SelectedItem as ComboBoxItem)?.Content.ToString();
            string tinggiBadan = txtTinggiBadan.Text;
            string beratBadan = txtBeratBadan.Text;
            string gender = (boxGender.SelectedItem as ComboBoxItem)?.Content.ToString();
            string noTelp = txtNoTelp.Text;



            if (string.IsNullOrWhiteSpace(namaPendonor) ||
                string.IsNullOrWhiteSpace(bloodType) ||
                string.IsNullOrWhiteSpace(tinggiBadan) ||
                string.IsNullOrWhiteSpace(beratBadan) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(noTelp) ||
                !cbkonfirmasi.IsChecked == true)
            {
                // Menampilkan pesan jika data belum lengkap
                MessageBox.Show("Data belum lengkap, mohon lengkapi data.", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            else
            {
                ClassBLL objbll = new ClassBLL();

                if (objbll.SaveVolunteerTable(txtNamaPendonor.Text, boxBloodType.SelectedValue.ToString(), txtTinggiBadan.Text, txtBeratBadan.Text, boxGender.SelectedValue.ToString(), txtNoTelp.Text))
                {
                    MessageBox.Show("PENDAFTARAN BERHASIL !");
                    Dashboard homepage = new Dashboard();
                    homepage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("PENDAFTARAN GAGAL, SILAHKAN PERIKSA KEMBALI");
                }
                //ditambahin koneksi ke database
                MessageBox.Show("Pendaftaran Berhasil!");
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

        
    }
}
