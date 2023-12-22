using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using MongoDB.Driver.Core.Configuration;
using MyBloodAppLogin.BLL;
using MyBloodAppLogin.DAL;
using MyBloodAppLogin.Homepage;

namespace MyBloodAppLogin
{
    public partial class Page1 : Window
    { 
        public Page1()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            ClassBLL objbll = new ClassBLL();
            if (objbll.SaveUserTable(txtEmailAddressRegist.Text, txtNama.Text, txtNIK.Text, boxGender.SelectedValue?.ToString(), txtAlamat.Text, txtTanggalLahir.Text,boxBloodType.SelectedValue?.ToString(),txtBodyWeight.Text,txtPassword.Text))
            {
                MessageBox.Show("PENDAFTARAN BERHASIL");
                Dashboard homepage = new Dashboard();
                homepage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("GAGAL, MOHON CEK DAN ULANG KEMBALI");
            }
        }

        private void AdaAkun_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow ();
            
            login.Show();
        }

        private void txtAlamat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
