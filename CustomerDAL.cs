using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpsonsDepartmentStore
{
    internal class CustomerDAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BeautyAndCosmeticsConnectionString"].ConnectionString;

        public static int addCustomer(string CustomerForename, string CustomerSurname, DateTime CustomerDOB, string CustomerAddress, string CustomerPostcode, string CustomerContactNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO Customer VALUES('{0}', '{1}', @date_param, '{2}', '{3}', '{4}')",
                    CustomerForename, CustomerSurname, CustomerAddress, CustomerPostcode, CustomerContactNumber);
                SqlCommand insertCustomerCommand = new SqlCommand(sqlQuery, connection);
                insertCustomerCommand.Parameters.Add("date_param", System.Data.SqlDbType.Date).Value = CustomerDOB.Date;
                int rowsAffected = insertCustomerCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static int updateCustomerInformation(string CustomerForename, string CustomerSurname, DateTime CustomerDOB, string CustomerAddress, string CustomerPostcode, string CustomerContactNumber, int CustomerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE Customer SET CustomerForename = '{0}', " +
                    "CustomerSurname = '{1}', CustomerDOB = @date_param, CustomerAddress = '{2}', CustomerPostcode = '{3}', CustomerContactNumber = '{4}' WHERE CustomerID = '{5}'",
                    CustomerForename, CustomerSurname, CustomerAddress, CustomerPostcode, CustomerContactNumber, CustomerID);
                SqlCommand updateCustomerCommand = new SqlCommand(sqlQuery, connection);
                updateCustomerCommand.Parameters.Add("date_param", System.Data.SqlDbType.Date).Value = CustomerDOB.Date;
                int rowsAffected = updateCustomerCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static List<string> CustomersBySurname(string CustomerSurname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> CustomerNames = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Customer WHERE CustomerSurname = '{0}'", CustomerSurname);
                SqlCommand customerByCustomerSurnameCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = customerByCustomerSurnameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string CustomerInfo = (sqlDataReader["CustomerID"] + ",");
                    CustomerInfo += sqlDataReader["CustomerForename"] + ",";
                    CustomerInfo += sqlDataReader["CustomerSurname"] + ",";
                    CustomerInfo += sqlDataReader["CustomerDOB"] + ",";
                    CustomerInfo += sqlDataReader["CustomerAddress"] + ",";
                    CustomerInfo += sqlDataReader["CustomerPostcode"] + ",";
                    CustomerInfo += sqlDataReader["CustomerContactNumber"] + ",";
                        
                    CustomerNames.Add(CustomerInfo);
                }
                connection.Close();
                return CustomerNames;

            }
        }

        public static List<string> selectAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> allCustomers = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Customer");
                SqlCommand getAllCustomersCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getAllCustomersCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string CustomerInfo = (sqlDataReader["CustomerID"] + ",");
                    CustomerInfo += sqlDataReader["CustomerForename"] + ",";
                    CustomerInfo += sqlDataReader["CustomerSurname"] + ",";
                    CustomerInfo += sqlDataReader["CustomerDOB"] + ",";
                    CustomerInfo += sqlDataReader["CustomerAddress"] + ",";
                    CustomerInfo += sqlDataReader["CustomerPostcode"] + ",";
                    CustomerInfo += sqlDataReader["CustomerContactNumber"] + ",";

                    allCustomers.Add(CustomerInfo);
                }
                connection.Close(); return allCustomers;
            }
        }

        public static int DeleteCustomer(string CustomerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SqlQuery = string.Format("DELETE FROM Customer WHERE CustomerID = '{0}'", CustomerID);
                SqlCommand deleteCustomerCommand = new SqlCommand(SqlQuery, connection);
                int rowsAffected = deleteCustomerCommand.ExecuteNonQuery();
                connection.Close(); return rowsAffected;
            }
        }

        public static List<string> SelectCustomersSurnames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> customersSurnames = new List<string>();
                string SqlQuery = string.Format("SELECT CustomerID, CustomerSurname FROM Customer");
                SqlCommand selectCustomersSurnamesCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectCustomersSurnamesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string CustomerSurnames = (sqlDataReader["CustomerID"] + ",");
                    CustomerSurnames += sqlDataReader["CustomerSurname"] + ",";
                    customersSurnames.Add(CustomerSurnames);
                }
                connection.Close(); return customersSurnames;
            }
        }

        public static List<string> CustomersByID(int CustomerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> CustomerIDs = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Customer WHERE CustomerID = '{0}'", CustomerID);
                SqlCommand customerByCustomerIDCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = customerByCustomerIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string CustomerInfo = (sqlDataReader["CustomerID"] + ",");
                    CustomerInfo += sqlDataReader["CustomerForename"] + ",";
                    CustomerInfo += sqlDataReader["CustomerSurname"] + ",";
                    CustomerInfo += sqlDataReader["CustomerDOB"] + ",";
                    CustomerInfo += sqlDataReader["CustomerAddress"] + ",";
                    CustomerInfo += sqlDataReader["CustomerPostcode"] + ",";
                    CustomerInfo += sqlDataReader["CustomerContactNumber"] + ",";

                    CustomerIDs.Add(CustomerInfo);
                }
                connection.Close();
                return CustomerIDs;

            }
        }
    }
}
