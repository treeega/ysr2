using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab.Method
{
    public class ConnectionSetting
    {
        public ConnectionSetting()
        {
        }

        public string ConnectionString { get; set; }
        public string ConnectionName = "Context"; //Название строки подключения
        public string ServerName { get; set; }
        public string CatalogName { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        //Для проверки во время задания новых параметров
        public bool CheckConnection(string serverName, string catalogName, bool integratedSecurity, string login, string password)
        {
            bool con = false;
            var coon = new SqlConnectionStringBuilder();
            if (integratedSecurity)
                coon = new SqlConnectionStringBuilder() { DataSource = serverName, InitialCatalog = catalogName, IntegratedSecurity = integratedSecurity };
            else
                coon = new SqlConnectionStringBuilder() { DataSource = serverName, InitialCatalog = catalogName, IntegratedSecurity = integratedSecurity, UserID = login, Password = password };

            using (SqlConnection connection = new SqlConnection(coon.ToString()))
            {
                try
                {

                    connection.Open();
                    con = true;
                }
                catch (SqlException)
                {
                    con = false;
                }
            }
            return con;
        }

        //Нужен для проверки при запуске программы
        public bool CheckDefaultConnection()
        {
            bool con = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RZPDbContext"].ConnectionString))
            {
                try
                {

                    connection.Open();
                    con = true;
                }
                catch (SqlException)
                {
                    con = false;
                }
            }
            return con;
        }

        public void GetConnectionString()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["RZPDbContext"].ConnectionString;
        }

        public void GetConnection()
        {
            try
            {

                var con = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString);
                ServerName = con.DataSource;
                CatalogName = con.InitialCatalog;
                IntegratedSecurity = con.IntegratedSecurity;
                Login = con.UserID;
                Password = con.Password;
            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.ToString()); }
        }

        public void SetConnection(string serverName, string catalogName, bool integratedSecurity, string login, string password)
        {
            try
            {

                var con = new SqlConnectionStringBuilder();
                if (integratedSecurity)
                    con = new SqlConnectionStringBuilder() { DataSource = serverName, InitialCatalog = catalogName, IntegratedSecurity = integratedSecurity };
                else
                    con = new SqlConnectionStringBuilder() { DataSource = serverName, InitialCatalog = catalogName, IntegratedSecurity = integratedSecurity, UserID = login, Password = password };

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings[ConnectionName].ConnectionString = con.ToString();
                config.Save();
            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.ToString()); }
        }
    }
}
