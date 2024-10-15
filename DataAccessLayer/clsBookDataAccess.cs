using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsBookDataAccess
    {

        public static bool findBookByTitle(ref int bookID, ref int authorID, string title, ref string genre, ref string ISBN, ref DateTime publishedDate, ref string additionalNotes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindBookByTitle";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Title", title);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    bookID = (int)reader["BookID"];
                    authorID = (int)reader["AuthorID"];
                    genre = (string)reader["Genre"];
                    ISBN = (string)reader["ISBN"];
                    publishedDate = (DateTime)reader["PublishedDate"];
                    additionalNotes = (string)reader["AdditionalNotes"];

                }


            }
            catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            }
            finally
            {
                connection.Close();
            }



            return isFound;
        }

        public static bool findBookByBookID(int bookID , ref int authorID, ref string title, ref string genre, ref string ISBN, ref DateTime publishedDate, ref string additionalNotes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindBookByBookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BookID", bookID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    authorID = (int)reader["AuthorID"];
                    title = (string)reader["Title"];
                    genre = (string)reader["Genre"];
                    ISBN = (string)reader["ISBN"];
                    publishedDate = (DateTime)reader["PublishedDate"];
                    additionalNotes = (string)reader["AdditionalNotes"];


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

        public static bool deleteBookCopyByBookCopyID(int bookCopyID)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteBookCopyByID";
            SqlCommand command = new SqlCommand(query, connection);
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

        public static int addNewBook(int authorID , string title , string genre , string ISBN , DateTime publishedDate , string additionalNotes)
        {
            int newBookID = 0;

            SqlConnection connection = new SqlConnection (clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue ("@AuthorID", authorID);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Genre", genre);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublishedDate", publishedDate);
            command.Parameters.AddWithValue("@AdditionalNotes", additionalNotes);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newBookID = id;
                }



            }
            catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }




            return newBookID;
        }

        public static bool doesBookExistByTitle(string title)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DoesBookExistByTitle";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Title", title);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static DataTable getBooksTitles()
        {
            DataTable dataTable = new DataTable();
            
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_GetBooksTitle";
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


            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);
            }


            return dataTable;
        }
    }
}
