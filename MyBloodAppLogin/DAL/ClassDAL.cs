using GoogleApi.Entities.Maps.AddressValidation.Response.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBloodAppLogin.DAL
{
    class ClassDAL
    {
        //ADD

        public bool AddUserTable(string email, string name, string NIK, string gender, string address, string birthday, string bloodType, string bodyWeight, string password)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query = "Insert INTO userTable(email,name,NIK,gender,address,birthday,bloodType,bodyWeight,password)values(@email,@name,@NIK,@gender,@address,@birthday,@bloodType,@bodyWeight,@password)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@email", email.Trim());
                    cmd.Parameters.AddWithValue("@name", name.Trim());
                    cmd.Parameters.AddWithValue("@NIK", NIK.Trim());
                    cmd.Parameters.AddWithValue("@gender", gender.Trim());
                    cmd.Parameters.AddWithValue("@address", address.Trim());
                    cmd.Parameters.AddWithValue("@birthday", birthday.Trim());
                    cmd.Parameters.AddWithValue("@bloodType", bloodType.Trim());
                    cmd.Parameters.AddWithValue("@bodyWeight", bodyWeight.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool AddEventTable(string organization, string eventName, string location, string date, string time, string quota, string noTelp, string description, string platform, string accountName)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query = "Insert into eventTable(organization,eventname,location,date,time,quota,noTelp,description,platform,accountName)values(@organization,@eventName,@location,@date,@time,@quota,@noTelp,@description,@platform,@accountName)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@organization", organization.Trim());
                    cmd.Parameters.AddWithValue("@eventName", eventName.Trim());
                    cmd.Parameters.AddWithValue("@location", location.Trim());
                    cmd.Parameters.AddWithValue("@date", date.Trim());
                    cmd.Parameters.AddWithValue("@time", time.Trim());
                    cmd.Parameters.AddWithValue("@quota", quota.Trim());
                    cmd.Parameters.AddWithValue("@noTelp", noTelp.Trim());
                    cmd.Parameters.AddWithValue("@description", description.Trim());
    
                    
                    cmd.Parameters.AddWithValue("@platform", platform.Trim());
                    cmd.Parameters.AddWithValue("@accountName", accountName.Trim());

                    cmd.ExecuteNonQuery(); 
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool AddVolunteerTable(string volunteerName, string volunteerBlood, string volunteerHeight, string volunteerWeight, string volunteerGender, string volunteerPhone)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query = "Insert into volunteerTable(volunteerName,volunteerBlood,volunteerHeight,volunteerWeight,volunteerGender,volunteerPhone)values(@volunteerName,@volunteerBlood,@volunteerHeight,@volunteerWeight,@volunteerGender,@volunteerPhone)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@volunteerName", volunteerName.Trim());
                    cmd.Parameters.AddWithValue("@volunteerBlood", volunteerBlood.Trim());
                    cmd.Parameters.AddWithValue("@volunteerHeight", volunteerHeight.Trim());
                    cmd.Parameters.AddWithValue("@volunteerWeight", volunteerWeight.Trim());
                    cmd.Parameters.AddWithValue("@volunteerGender", volunteerGender.Trim());
                    cmd.Parameters.AddWithValue("@volunteerPhone", volunteerPhone.Trim());

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        
        }


        //READ
        public DataTable ReadUserTable()
        {
            Connection con = new Connection();
            if(ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM userTable";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadEventTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM eventTable";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadVolunteerTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM volunteerTable";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
