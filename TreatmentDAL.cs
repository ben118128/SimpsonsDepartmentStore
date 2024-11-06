using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SimpsonsDepartmentStore
{
    internal class TreatmentDAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BeautyAndCosmeticsConnectionString"].ConnectionString;


        /*public static int TreatmentCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("SELECT COUNT(TreatmentID) FROM Treatment");
                SqlCommand tCount = new SqlCommand(sqlQuery, connection);
                int rowsAffected = tCount.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }*/ 

        public static int AddTreatment(string TreatmentName, string TreatmentDescription, string TreatmentContents, decimal TreatmentCost)
        {
            //int TreatmentID = TreatmentDAL.TreatmentCount() + 1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO Treatment VALUES('{0}', '{1}', '{2}', '{3}')",
                    TreatmentName, TreatmentDescription, TreatmentContents, TreatmentCost);
                SqlCommand insertTreatmentCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = insertTreatmentCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static int updateTreatmentsInformation(string TreatmentName, string TreatmentDescription, string TreatmentContents, decimal TreatmentCost, int TreatmentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE Treatment SET TreatmentName = '{0}', " +
                    "TreatmentDescription = '{1}', TreatmentContents = '{2}', TreatmentCost = '{3}' WHERE TreatmentID = '{4}'",
                    TreatmentName, TreatmentDescription, TreatmentContents, TreatmentCost, TreatmentID);
                SqlCommand updateTreatmentCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = updateTreatmentCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static List<string> treatmentsByTreatmentName(string TreatmentName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> treatmentNames = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Treatment WHERE TreatmentName = '{0}'", TreatmentName);
                SqlCommand treatmentsByTreatmentNameCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = treatmentsByTreatmentNameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string treatmentInfo = (sqlDataReader["TreatmentID"] + ",");
                    treatmentInfo += sqlDataReader["TreatmentName"] + ",";
                    treatmentInfo += sqlDataReader["TreatmentDescription"] + ",";
                    treatmentInfo += sqlDataReader["TreatmentContents"] + ",";
                    treatmentInfo += sqlDataReader["TreatmentCost"] + ",";

                    treatmentNames.Add(treatmentInfo);
                }
                connection.Close();
                return treatmentNames;

            }
        }

        public static List<string> SelectAllTreatments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> allTreatments = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM TREATMENT");
                SqlCommand getAllTreatmentsCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getAllTreatmentsCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string treatmentInfo = sqlDataReader["TreatmentID"] + ",";
                    treatmentInfo += sqlDataReader["TreatmentName"] + ", ";
                    treatmentInfo += sqlDataReader["TreatmentDescription"] + ",";
                    treatmentInfo += sqlDataReader["TreatmentContents"] + ",";
                    treatmentInfo += sqlDataReader["TreatmentCost"] + ",";

                    allTreatments.Add(treatmentInfo);
                }
                connection.Close();
                return allTreatments;
            }
        }

        public static int DeleteTreatment(string TreatmentName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("DELETE FROM Treatment WHERE TreatmentName = '{0}'", TreatmentName);
                SqlCommand deleteTreatmentCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = deleteTreatmentCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static List<string> SelectTreatmentNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> treatmentNames = new List<string>();
                string SqlQuery = string.Format("SELECT TreatmentID, TreatmentName FROM Treatment");
                SqlCommand selectTreatmentNamesCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectTreatmentNamesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string TreatmentNames = (sqlDataReader["TreatmentID"] + ",");
                    TreatmentNames += sqlDataReader["TreatmentName"] + ",";
                    treatmentNames.Add(TreatmentNames);
                }
                connection.Close(); return treatmentNames;
            }
        }
    }
}
