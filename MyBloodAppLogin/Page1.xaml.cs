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

namespace MyBloodAppLogin
{
    public partial class Page1 : Page
    {
        public string connectionString = @"Data Source=EKARAHMADI\SQLEXPRESS;Database=myBloodLogReg;Integrated Security=True";

        public Page1()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conReg = new SqlConnection(connectionString))
              
                {
                    conReg.Open();

                    string add_data = "INSERT INTO [dbo].[user] VALUES(@emailUser,@nameUser,@NIKUser,@genderUser,@addressUser,@birthdayUser,@bltypeUser,@weightUser,@passwordUser)";
                    using (SqlCommand cmd = new SqlCommand(add_data, conReg))
                    {
                        cmd.Parameters.AddWithValue("@emailUser", txtEmailAddressRegist.Text);
                        cmd.Parameters.AddWithValue("@nameUser", txtNama.Text);
                        cmd.Parameters.AddWithValue("@NIKUser", txtNIK.Text);
                        cmd.Parameters.AddWithValue("@genderUser", boxGender.SelectedValue?.ToString()); // Gunakan SelectedValue
                        cmd.Parameters.AddWithValue("@addressUser", txtAlamat.Text);
                        cmd.Parameters.AddWithValue("@birthdayUser", txtTanggalLahir.Text);
                        cmd.Parameters.AddWithValue("@bltypeUser", boxBloodType.SelectedValue?.ToString()); // Gunakan SelectedValue
                        cmd.Parameters.AddWithValue("@weightUser", txtBodyWeight.Text);
                        cmd.Parameters.AddWithValue("@passwordUser", txtPassword.Text);

                        cmd.ExecuteNonQuery();
                    }

                    // Commit transaksi
                    using (SqlTransaction transaction = conReg.BeginTransaction())
                    {
                        transaction.Commit();
                    }
                }

                MessageBox.Show("Registrasi berhasil!");

                // Bersihkan input setelah registrasi
                txtEmailAddressRegist.Text = "";
                txtNama.Text = "";
                txtNIK.Text = "";
                txtAlamat.Text = "";
                txtTanggalLahir.Text = "";
                txtBodyWeight.Text = "";
                txtPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void txtEmailAddressRegist_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Logika yang mungkin Anda tambahkan di sini
        }

        private void AdaAkun_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow ();
            Page1 page = new Page1 ();  
            login.Show();
        }

        private void boxBloodType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
