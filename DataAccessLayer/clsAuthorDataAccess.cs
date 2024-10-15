using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsAuthorDataAccess
    {

        public static bool findAuthorByID(int authorID , ref int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindAuthorByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AuthorID", authorID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["PersonID"];
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

        public static int addNewAuthor(int personID)
        {
            int newAuthorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewAuthor";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", personID);


            try
            {
                connection.Open();

                object result = command.ExecuteNonQuery();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newAuthorID = id;
                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            }
             finally
            {
                connection.Close();
            }





            return newAuthorID;
        }




    }
}
