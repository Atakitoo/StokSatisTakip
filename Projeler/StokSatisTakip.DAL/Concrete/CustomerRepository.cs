using MySql.Data.MySqlClient;
using System.Collections.Generic;
using StokSatisTakip.DAL.Helpers;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.DAL.Concrete
{
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            var customers = new List<Customer>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT Id, FirstName, LastName, CustomerType, Email, Phone
                                 FROM customers";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            Id = reader.GetInt32("Id"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            CustomerType = reader.GetString("CustomerType"),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString("Email"),
                            Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? "" : reader.GetString("Phone")
                        });
                    }
                }
            }

            return customers;
        }

        public void Add(Customer customer)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO customers (FirstName, LastName, CustomerType, Email, Phone)
                                 VALUES (@FirstName, @LastName, @CustomerType, @Email, @Phone)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@CustomerType", customer.CustomerType);
                    cmd.Parameters.AddWithValue("@Email", customer.Email ?? "");
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Customer customer)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE customers SET
                                    FirstName = @FirstName,
                                    LastName = @LastName,
                                    CustomerType = @CustomerType,
                                    Email = @Email,
                                    Phone = @Phone
                                 WHERE Id = @Id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", customer.Id);
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@CustomerType", customer.CustomerType);
                    cmd.Parameters.AddWithValue("@Email", customer.Email ?? "");
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM customers WHERE Id = @Id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}