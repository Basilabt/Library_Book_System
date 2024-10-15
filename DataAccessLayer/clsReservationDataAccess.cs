using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

using c = System.Console;

namespace DataAccessLayer
{
    public class clsReservationDataAccess
    {
        public static DataTable getAllReservations()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
            {

                try
                {
                    connection.Open();

                    string query = "SP_GetAllReservations";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }

                        }

                    }

                } catch(Exception exception) 
                {
                    Console.WriteLine("DEBUG: {0}",exception.Message);
                }

            }


                return dataTable;
        }

        public static int addNewReservation(string bookTitle , string userPhoneNumber , DateTime reservationDate)
        {
            int newReservationID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
            {

                try
                {
                    connection.Open();

                    string query = "SP_AddNewReservation";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookTitle", bookTitle);
                        command.Parameters.AddWithValue("@PhoneNumber", userPhoneNumber);
                        command.Parameters.AddWithValue("@ReservationDate", reservationDate);

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            newReservationID = id;
                        }

                    }


                } catch (Exception exception)
                {
                    Console.WriteLine("DEBUG: {0}", exception.Message);
                }
             
            }



            return newReservationID;
        }

        public static bool deleteReservationByReservationID(int reservationID)
        {
            int numberOfAffectedRows = 0;


            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
            {

               try
                {
                    connection.Open();

                    string query = "SP_DeleteReservation";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {   
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", reservationID);

                        numberOfAffectedRows = command.ExecuteNonQuery();

                    }


                } catch (Exception exception)
                {
                    Console.WriteLine("DEBUG: {0}", exception.Message);
                }



            } 




                return numberOfAffectedRows >= 1;
        }

        public static bool doesReservationExistByFullname(string fullname)
        {
            bool isFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
            {
                try
                {

                    connection.Open();

                    string query = "SP_DoesReservationExistByFullname";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Fullname", fullname);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                            }

                        }

                    }


                } catch (Exception exception)
                {
                    c.WriteLine("DEBUG: {0}",exception.Message);
                }


            }




                return isFound;
        }

        public static bool findReservationByReservationID(int reservationID , ref int bookCopyID , ref int userID , ref DateTime reservationDate)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
            {
                
                try
                {
                    connection.Open();

                    string query = "SP_FindReservationByReservationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", reservationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                bookCopyID = (int)reader["BookCopyID"];
                                userID = (int)reader["UserID"];
                                reservationDate = (DateTime)reader["ReservationDate"];

                            }


                        }

                    }

                } catch (Exception exception)
                {

                    c.WriteLine("DEBUG: {0}",exception.Message);
                }

            }



            return isFound;
        }

        

    }
}
