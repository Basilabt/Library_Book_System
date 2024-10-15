using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsBorrowingDataAccess
    {

        public static int addNewBorrowing(int bookCopyID , int userID , DateTime startDate , DateTime endDate , DateTime actualReturnDate)
        {
            int newBorrowingID = -1;

            try
            {

                using(SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_AddNewBorrowing";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookCopyID",bookCopyID);
                        command.Parameters.AddWithValue("@UserID",userID);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@ActualReturnDate", DBNull.Value);

                        Object result = command.ExecuteScalar(); 
                       
                            if (result != null && int.TryParse(result.ToString(), out int id))
                            {
                                newBorrowingID = id;
                            }                        
                    }

                }

            } catch (Exception exxeption) 
            {
                Console.WriteLine("DEBUG: {0}", exxeption.Message);
            }




            return newBorrowingID;
        }

        public static bool deleteBorrowing(int borrwoingID)
        {
            int numberOfAffectedRows = 0;

            try
            {

                using(SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_DeleteBorrowingByBorrowingID";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BorrowingID", borrwoingID);

                        numberOfAffectedRows = command.ExecuteNonQuery();

                    }

                }


            } catch (Exception exxeption)
            {
                Console.WriteLine("DEBUG: {0}", exxeption.Message);
            }
            

            return numberOfAffectedRows >= 1;
        }

        public static DataTable getAllBorrowings()
        {
            DataTable dataTable = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {   
                    connection.Open();

                    string query = "SP_GetAllBorrowings";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }


                        }


                    }

                }

            } catch (Exception exxeption)
            {
                Console.WriteLine("DEBUG: {0}", exxeption.Message);
            }


            return dataTable;
        }

        public static bool doesBorrowingExist(string bookTitle , string fullname)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_FindBorrowingByBookTitle";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookTitle", bookTitle);
                        command.Parameters.AddWithValue("@Fullname", fullname);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                isFound = true;
                            }

                        }

                    }

                }


            } catch(Exception exxeption)
            {
                Console.WriteLine("DEBUG: {0}",exxeption.Message);
            }

            return isFound;
        }

        public static bool findBorrowingByBorrowingID(int borrowingID , ref int bookCopyID , ref int userID , ref DateTime startDate , ref DateTime endDate , ref DateTime actualReturnDate)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_FindBorrowingByBorrowingID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BorrowingID", borrowingID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {   

                                isFound = true;

                                bookCopyID = (int)reader["BookCopyID"];
                                userID = (int)reader["UserID"];
                                startDate = (DateTime)reader["StartDate"];
                                endDate = (DateTime)reader["EndDate"];
                                actualReturnDate = (DateTime)reader["ActualReturnDare"];
                            }


                        }

                    }


                }


            } catch (Exception exxeption)
            {
                Console.WriteLine("DEBUG: {0}",exxeption.Message);
            }



            return isFound;
        }

        public static bool returnBorrowing(int borrowingID)
        {
            int numberOfAffectedRows = 0;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_ReturnBorrowing";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BorrowingID", borrowingID);

                        numberOfAffectedRows = command.ExecuteNonQuery();

                    }

                }


            }
            catch (Exception exxeption)
            {
                Console.WriteLine("DEBUG: {0}", exxeption.Message);
            }


            return numberOfAffectedRows >= 1;
        }


    }
}
