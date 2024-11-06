using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static SimpsonsDepartmentStore.BeautyAndCosmeticsDataSet1;

namespace SimpsonsDepartmentStore
{
    internal class StaffDAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BeautyAndCosmeticsConnectionString"].ConnectionString;

        public static int addStaff(string StaffForename, string StaffSurname, string StaffType, DateTime StaffDOB, string StaffAddress, string StaffPostcode, string StaffContactNumber)
        {
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO Staff VALUES('{0}', '{1}', '{2}', @date_param, '{4}', '{5}', '{6}')",
                    StaffForename, StaffSurname, StaffType, StaffAddress, StaffPostcode, StaffContactNumber);
                SqlCommand insertStaffCommand = new SqlCommand(sqlQuery, connection);
                insertStaffCommand.Parameters.Add("date_param", System.Data.SqlDbType.Date).Value = StaffDOB.Date;
                int rowsAffected = insertStaffCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static int updateStaffInformation(string StaffSurname, string StaffForename, string StaffType, DateTime StaffDOB, string StaffAddress, string StaffPostcode, string StaffContactNumber, int staffID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE Staff SET StaffSurname = '{0}', " +
                    "StaffForename = '{1}', StaffType = '{2}', StaffDOB = @date_param, StaffAddress = '{3}', StaffPostcode = '{4}', StaffContactNumber = '{5}' WHERE StaffID = '{6}'",
                    StaffSurname, StaffForename, StaffType, StaffAddress, StaffPostcode, StaffContactNumber, staffID);
                SqlCommand updateStaffCommand = new SqlCommand(sqlQuery, connection);
                updateStaffCommand.Parameters.Add("date_param", System.Data.SqlDbType.Date).Value =StaffDOB.Date;
                int rowsAffected = updateStaffCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static List<string> staffBySurname(string StaffSurname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> staffNames = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Staff WHERE StaffSurname = '{0}'", StaffSurname);
                SqlCommand staffByStaffSurnameCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = staffByStaffSurnameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string staffInfo = (sqlDataReader["StaffID"] + ",");
                    staffInfo += sqlDataReader["StaffForename"] + ",";
                    staffInfo += sqlDataReader["StaffSurname"] + ",";
                    staffInfo += sqlDataReader["StaffType"] + ",";
                    staffInfo += sqlDataReader["StaffDOB"] + ",";
                    staffInfo += sqlDataReader["StaffAddress"] + ",";
                    staffInfo += sqlDataReader["StaffPostcode"] + ",";
                    staffInfo += sqlDataReader["StaffContactNumber"] + ",";

                    staffNames.Add(staffInfo);
                }
                connection.Close();
                return staffNames;

            }
        }

        public static List<string> selectAllStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> allStaff = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Staff");
                SqlCommand getAllStaffCommand= new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader= getAllStaffCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string staffInfo = (sqlDataReader["StaffID"] + ",");
                    staffInfo += sqlDataReader["StaffForename"] + ",";
                    staffInfo += sqlDataReader["StaffSurname"] + ",";
                    staffInfo += sqlDataReader["StaffType"] + ",";
                    staffInfo += sqlDataReader["StaffDOB"] + ",";
                    staffInfo += sqlDataReader["StaffAddress"] + ",";
                    staffInfo += sqlDataReader["StaffPostcode"] + ",";
                    staffInfo += sqlDataReader["StaffContactNumber"] + ",";

                    allStaff.Add(staffInfo);
                }
                connection.Close(); return allStaff;
            }
        }

        public static int DeleteStaff(string StaffID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SqlQuery = string.Format("DELETE FROM Staff WHERE StaffID = '{0}'", StaffID);
                SqlCommand deleteStaffCommand= new SqlCommand(SqlQuery, connection);
                int rowsAffected = deleteStaffCommand.ExecuteNonQuery();
                connection.Close(); return rowsAffected;
            }
        }

        public static List<string> SelectStaffSurnames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> staffSurnames = new List<string>();
                string SqlQuery = string.Format("SELECT StaffID, StaffSurname FROM Staff");
                SqlCommand selectStaffSurnamesCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectStaffSurnamesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string StaffSurnames = (sqlDataReader["StaffID"] + ",");
                    StaffSurnames += sqlDataReader["StaffSurname"] + ",";
                    staffSurnames.Add(StaffSurnames);
                }
                connection.Close(); return staffSurnames;
            }
        }

        public static List<string> SelectStaffTypes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> staffTypes = new List<string>();
                string SqlQuery = string.Format("Select StaffID, StaffType FROM Staff");
                SqlCommand selectStaffTypesCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectStaffTypesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string StaffTypes = (sqlDataReader["StaffID"] + ",");
                    StaffTypes += sqlDataReader["StaffType"] + ",";
                    staffTypes.Add(StaffTypes);
                }
                connection.Close(); return staffTypes;
            }
        }

        public static List<string> staffByID(int StaffID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> staffIDs = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Staff WHERE StaffID = '{0}'", StaffID);
                SqlCommand staffByStaffIDCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = staffByStaffIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string staffInfo = (sqlDataReader["StaffID"] + ",");
                    staffInfo += sqlDataReader["StaffForename"] + ",";
                    staffInfo += sqlDataReader["StaffSurname"] + ",";
                    staffInfo += sqlDataReader["StaffType"] + ",";
                    staffInfo += sqlDataReader["StaffDOB"] + ",";
                    staffInfo += sqlDataReader["StaffAddress"] + ",";
                    staffInfo += sqlDataReader["StaffPostcode"] + ",";
                    staffInfo += sqlDataReader["StaffContactNumber"] + ",";

                    staffIDs.Add(staffInfo);
                }
                connection.Close();
                return staffIDs;

            }
        }
    }
}
