using MySql.Data.MySqlClient;
using RegularClassAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegularClassAPI.Controllers
{
    public class AdminController : ApiController
    {
        // GET api/class/{ClassId}
        [HttpGet]
        public Admin GetSingleClass(int classId)
        {
            Admin admin = new Admin();
            return admin;
        }

        // GET api/class
        [HttpGet]
        public IEnumerable<Admin> AdminList()
        {
            List<Admin> adminList = new List<Admin>();

            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "MYSQL5018.Smarterasp.net";
            string database = "db_9f39b3_regular";
            string uid = "9f39b3_regular";
            string password = "Passw0rd#";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from admin";
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {

                    while (reader.Read())
                    {
                        Admin admin = new Admin();

                        admin.Id = Convert.ToInt32(reader["admin_id"]);
                        admin.FName = Convert.ToString(reader["Fname"]);
                        admin.LName = Convert.ToString(reader["Lname"]);
                        admin.Class_Id = Convert.ToInt32(reader["class_id"]);
                        adminList.Add(admin);
                    }
                }
                catch (MySqlException e)
                {
                    string MessageString = "Read error occurred  / entry not found loading the Column details: " + e.ErrorCode + " - " + e.Message + "; \n\nPlease Continue";
                }
            }
            catch (MySqlException e)
            {
                string MessageString = "The following error occurred loading the Column details: " + e.ErrorCode + " - " + e.Message;
            }

            connection.Close();

            return adminList;
        }

        // GET api/values/[Class Object]
        [HttpPost]
        public string AddClass(Admin classObj)
        {
            return "okay";
        }

        // GET api/values/[Class Object]
        [HttpDelete]
        public string DeleteClass(int classId)
        {
            return "okay";
        }

    }
}
