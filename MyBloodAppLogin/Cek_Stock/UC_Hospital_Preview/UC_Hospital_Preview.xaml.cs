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

namespace MyBloodAppLogin.Cek_Stock.UC_Hospital_Preview
{
    /// <summary>
    /// Interaction logic for UC_Hospital_Preview.xaml
    /// </summary>
    public partial class UC_Hospital_Preview : UserControl
    {
        public UC_Hospital_Preview()
        {
            InitializeComponent();
            this.DataContext = this;
            Icon_Hospital_Maps.Source = new BitmapImage(new Uri("/Assets/img_maps.png", UriKind.Relative));
        }
        public string HospitalName { get; set }
        public string HospitalAddress { get; set }
        public string HospitalOpen { get; set }
        public string HospitalTelephone { get; set }
        public string HospitalPicture { get; set }


    }
}
