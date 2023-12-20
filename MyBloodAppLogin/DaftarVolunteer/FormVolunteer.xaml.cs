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
    public partial class FormVolunteer : Page
    {
        public FormVolunteer()
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
                //ditambahin koneksi ke database
                MessageBox.Show("Pendaftaran Berhasil!");
            }
        }


    }
}
