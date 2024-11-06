using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace SimpsonsDepartmentStore
{
    internal class BookingDAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BeautyAndCosmeticsConnectionString"].ConnectionString;

        public static int addBooking(string BookingCustomer, DateTime BookingDate, string BookingRoom, string BookingContents, string AssignedStaff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO Booking VALUES('{0}', @date_param, '{1}', '{2}', '{3}')",
                    BookingCustomer, BookingRoom, BookingContents, AssignedStaff);
                SqlCommand insertBookingCommand = new SqlCommand(sqlQuery, connection);
                insertBookingCommand.Parameters.Add("date_param", System.Data.SqlDbType.Date).Value = BookingDate.Date;
                int rowsAffected = insertBookingCommand.ExecuteNonQuery();
                connection.Close(); return rowsAffected;
            }
        }

        public static int updateBookingInformation(string BookingCustomer, DateTime BookingDate, string BookingRoom, string BookingContents, string AssignedStaff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE Booking SET BookingCustomer = '{0}', " +
                    "BookingDate = @date_param, BookingRoom = '{1}', BookingContents = '{2}', AssignedStaff = '{3}'",
                    BookingCustomer, BookingRoom, BookingContents, AssignedStaff);
                SqlCommand updateBookingCommand = new SqlCommand(sqlQuery, connection);
                updateBookingCommand.Parameters.Add("date_param", System.Data.SqlDbType.Date).Value = BookingDate.Date;
                int rowsAffected = updateBookingCommand.ExecuteNonQuery();
                connection.Close(); return rowsAffected;
            }
        }

        public static List<string> BookingsByCustomer(string BookingCustomer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> BookingNames = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Booking WHERE BookingCustomer = '{0}'", BookingCustomer);
                SqlCommand bookingByBookingCustomerCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = bookingByBookingCustomerCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string BookingInfo = (sqlDataReader["BookingID"] + ",");
                    BookingInfo += sqlDataReader["BookingCustomer"] + ",";
                    BookingInfo += sqlDataReader["BookingDate"] + ",";
                    BookingInfo += sqlDataReader["BookingRoom"] + ",";
                    BookingInfo += sqlDataReader["BookingContents"] + ",";
                    BookingInfo += sqlDataReader["AssignedStaff"] + ",";

                    BookingNames.Add(BookingInfo);
                }
                connection.Close();
                return BookingNames;

            }
        }

        public static List<string> selectAllBookings()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> allBookings = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Booking");
                SqlCommand getAllBookingsCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getAllBookingsCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string BookingInfo = (sqlDataReader["BookingID"] + ",");
                    BookingInfo += sqlDataReader["BookingCustomer"] + ",";
                    BookingInfo += sqlDataReader["BookingDate"] + ",";
                    BookingInfo += sqlDataReader["BookingRoom"] + ",";
                    BookingInfo += sqlDataReader["BookingContents"] + ",";
                    BookingInfo += sqlDataReader["AssignedStaff"] + ",";

                    allBookings.Add(BookingInfo);
                }
                connection.Close(); return allBookings;
            }
        }

        public static int DeleteBooking(string BookingID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SqlQuery = string.Format("DELETE FROM Booking WHERE BookingID = '{0}'", BookingID);
                SqlCommand deleteBookingCommand = new SqlCommand(SqlQuery, connection);
                int rowsAffected = deleteBookingCommand.ExecuteNonQuery();
                connection.Close(); return rowsAffected;
            }
        }

        public static List<string> getBookingRooms()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> bookingRooms = new List<string>();
                string SqlQuery = string.Format("SELECT BookingRoom FROM Booking");
                SqlCommand selectBookingRoomsCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectBookingRoomsCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string BookingRooms = (sqlDataReader["BookingRoom"] + ",");

                    bookingRooms.Add(BookingRooms);
                }
                connection.Close(); return bookingRooms;
            }
        }

        public static List<string> getBookingDates()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> bookingDates = new List<string>();
                string SqlQuery = string.Format("SELECT BookingRoom FROM Booking");
                SqlCommand selectBookingDatesCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectBookingDatesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string BookingDates = (sqlDataReader["BookingRoom"] + ",");

                    bookingDates.Add(BookingDates);
                }
                connection.Close(); return bookingDates;
            }
        }

        public static List<string> getAssignedStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<string> assignedStaff = new List<string>();
                string SqlQuery = string.Format("Select AssignedStaff FROM Booking");
                SqlCommand selectAssignedStaffCommand = new SqlCommand(SqlQuery, connection);
                SqlDataReader sqlDataReader = selectAssignedStaffCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string AssignedStaff = (sqlDataReader["AssignedStaff"] + ",");

                    assignedStaff.Add(AssignedStaff);
                }
                connection.Close(); return assignedStaff;
            }
        }

        public static List<string> BookingsByID(int BookingID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> BookingIDs = new List<string>();
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Booking WHERE BookingID = '{0}'", BookingID);
                SqlCommand bookingByBookingIDCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = bookingByBookingIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string BookingInfo = (sqlDataReader["BookingID"] + ",");
                    BookingInfo += sqlDataReader["BookingCustomer"] + ",";
                    BookingInfo += sqlDataReader["BookingDate"] + ",";
                    BookingInfo += sqlDataReader["BookingRoom"] + ",";
                    BookingInfo += sqlDataReader["BookingContents"] + ",";
                    BookingInfo += sqlDataReader["AssignedStaff"] + ",";

                    BookingIDs.Add(BookingInfo);
                }
                connection.Close();
                return BookingIDs;

            }
        }
    }
}
