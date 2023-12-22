using MyBloodAppLogin.DaftarVolunteer;
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

namespace MyBloodAppLogin.EventList
{
    /// <summary>
    /// Interaction logic for UC_EventListxaml.xaml
    /// </summary>
    public partial class UC_EventListxaml : UserControl
    {
        public UC_EventListxaml()
        {
            InitializeComponent();
        }

        private void DaftarEvent_Click(object sender, RoutedEventArgs e)
        {
            EventModel selectedEvent = (EventModel)DataContext;

            FormVolunteer formVolunteer = new FormVolunteer();
            formVolunteer.Label_Event = selectedEvent.Event_Name;
            formVolunteer.Show();
        }
    }
}
