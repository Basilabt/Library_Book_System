using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsBookCopyDataAccess
    {
        public static DataTable getAllAvailableBooks()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetAvailableBooks";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }





            return dataTable;
        }

        public static bool doesBookCopyExistByTitle(string title)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DoesBookCopyExistByTitle";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Title", title);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    isFound = true;
                }


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }




            return isFound;
        }

        public static bool insertMultipleBookCopies(int bookID , int numberOfCopies)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddBookCopies";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BookID", bookID);
            command.Parameters.AddWithValue("@NumberOfAddedCopies", numberOfCopies);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();

            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }



            return numberOfAffectedRows >= 1;
        }

        public static bool deleteBookCopyByID(int bookCopyID)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteBookCopyByID";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BookCopyID", bookCopyID);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return numberOfAffectedRows >= 1;
        }

        public static bool findBookCopyByBookCopyID(int bookCopyID , ref int bookID , ref bool isAvailable)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindBookCopyByBookCopyID";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BookCopyID", bookCopyID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    bookID = (int)reader["BookID"];
                    isAvailable = (bool)reader["IsAvailable"];

                }


            } catch(Exception exception) 
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static int findAvailableBookCopyIDByBookTitle(string bookTitle)
        {
            int bookCopyID = -1;

            
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_FindAvailableBookCopyIDByBookTitle";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookTitle", bookTitle);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                bookCopyID = (int)reader["BookCopyID"];
                            }

                        }

                    }

                }


            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);
            }



             return bookCopyID;
        }

    }
}
