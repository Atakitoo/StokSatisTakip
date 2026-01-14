using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StokSatisTakip.DAL.Abstract;
using StokSatisTakip.DAL.Helpers;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User GetByEmailAndPassword(string email, string password)
        {
            User user = null;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT Id, FullName, Email, Phone, Password, Role 
                                 FROM users 
                                 WHERE Email = @email AND Password = @password";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Id = reader.GetInt32("Id"),
                            FullName = reader.GetString("FullName"),
                            Email = reader.GetString("Email"),
                            Phone = reader.GetString("Phone"),
                            Password = reader.GetString("Password"),
                            Role = reader.GetString("Role")
                        };
                    }
                }
            }

            return user;
        }
    }
}