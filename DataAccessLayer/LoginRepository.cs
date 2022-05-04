using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class LoginRepository
    {
        readonly string SqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public List<User> GetUsers()
        {
            List<User> korisnici = new List<User>();
            //string connectionString = @"Data Source=193.198.57.183,1433;Network Library=DBMSSOCN;Initial Catalog=STUDENTI_PIN;User ID=pin;Password=Vsmti1234!;";
            SqlConnection cnn = new SqlConnection(SqlConnectionString);
            cnn.Open();
            string Q = "SELECT * FROM Krpan_Users";
            SqlCommand command = new SqlCommand(Q, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                korisnici.Add(new User()
                {
                    UserID = Convert.ToInt32(dataReader["UserID"]),
                    Name = dataReader["Name"].ToString(),
                    Surname = dataReader["Surname"].ToString(),
                    Username = dataReader["Username"].ToString(),
                    Email = dataReader["Email"].ToString(),
                    Password = dataReader["Password"].ToString()
                });
            }
            return korisnici;
        }
        public void AddUser(string name, string surname, string username, string email, string pw)
        {
            //string connectionString = @"Data Source=193.198.57.183,1433;Network Library=DBMSSOCN;Initial Catalog=STUDENTI_PIN;User ID=pin;Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(SqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Krpan_Users (Name, Surname, Username, Email, Password) VALUES ('" + name + "','" + surname + "','" + username + "','" + email + "','"+pw+"')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public bool CheckUsername(string username)
        {
            var korisnici = GetUsers();
            foreach(User kor in korisnici)
            {
                if(kor.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckEmail(string email)
        {
            var korisnici = GetUsers();
            foreach(User kor in korisnici)
            {
                if (kor.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
