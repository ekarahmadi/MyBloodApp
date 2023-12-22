using MyBloodAppLogin.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows;
using MyBloodAppLogin.DAL;

namespace MyBloodAppLogin.BLL
{
    class ClassBLL
    {
        //SAVE
        public bool SaveUserTable(string email, string name, string NIK, string gender, string address, string birthday, string bloodType, string bodyWeight, string password)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddUserTable(email, name, NIK, gender, address, birthday, bloodType, bodyWeight, password);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool SaveEventTable(string organization, string eventName, string location, string date, string time, string quota, string noTelp, string description, string platform, string accountName)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddEventTable(organization, eventName, location, date, time, quota, noTelp, description, platform, accountName);
            }
            catch (Exception e)
            {
                 MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool SaveVolunteerTable(string volunteerName, string volunteerBlood, string volunteerHeight, string volunteerWeight, string volunteerGender, string volunteerPhone)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddVolunteerTable(volunteerName, volunteerBlood, volunteerHeight, volunteerWeight, volunteerGender, volunteerPhone);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        //GET
        public DataTable GetUserItem()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadUserTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetEventItem()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadEventTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetVolunteerItem()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadVolunteerTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
