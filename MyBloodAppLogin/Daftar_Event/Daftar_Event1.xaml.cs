using Microsoft.Win32;
using MyBloodAppLogin.BLL;
using MyBloodAppLogin.Cek_Stock;
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
using System.IO;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace MyBloodAppLogin.Daftar_Event
{
    /// <summary>
    /// Interaction logic for Daftar_Event1.xaml
    /// </summary>
    public partial class Daftar_Event1 : Window
    {
        public Daftar_Event1()
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

        //Menu Utama
       
        private void UploadVerifikasiButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DaftarAksi_Click(object sender, RoutedEventArgs e)
        {
            string namaOrganisasi = DataOrganizationName.Text;
            string namaEvent = DataEventName.Text;
            string namaLokasi = DataLocation.Text;
            string tanggalEvent = DataDate.Text;
            string waktuEvent = DataClock.Text;
            string kuotaEvent = DataKuota.Text;
            string teleponEvent = DataTelepon.Text;
            string platformevent = DataPlatform.Text;
            string platformNama = DataPlatformAccount.Text;
            string deskripsiEvent = DataDescription.Text;

            if (string.IsNullOrWhiteSpace(namaOrganisasi) ||
                string.IsNullOrWhiteSpace(namaEvent) ||
                string.IsNullOrWhiteSpace(namaLokasi) ||
                string.IsNullOrWhiteSpace(tanggalEvent) ||
                string.IsNullOrWhiteSpace(waktuEvent) ||
                string.IsNullOrWhiteSpace(kuotaEvent) ||
                string.IsNullOrWhiteSpace(teleponEvent)||
                string.IsNullOrWhiteSpace(platformevent) ||
                string.IsNullOrWhiteSpace(platformNama) ||
                string.IsNullOrWhiteSpace(deskripsiEvent) ||
                !cbkonfirmasiEvent.IsChecked == true)
            {
                // Menampilkan pesan jika data belum lengkap
                MessageBox.Show("Data belum lengkap, mohon lengkapi data.", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                ClassBLL objbll = new ClassBLL();

                if (objbll.SaveEventTable(DataOrganizationName.Text, DataEventName.Text, DataLocation.Text, DataDate.Text, DataClock.Text, DataKuota.Text, DataTelepon.Text, DataDescription.Text, DataPlatform.Text, DataPlatformAccount.Text))
                {
                    MessageBox.Show("PENDAFTARAN BERHASIL, SILAHKAN TUNGGU VERIFIKASI");
                    Dashboard homepage = new Dashboard();
                    homepage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("PENDAFTARAN GAGAL, SILAHKAN PERIKSA KEMBALI");
                }
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
