using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsLibraryMangerDataAccess
    {
        public static bool isLibraryManagerAccountActive(string username)
        {

            bool isActive = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_IsManagerAccountActive";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isActive = true;
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

            return isActive;

        }


        public static bool loginByUsernameAndPassword(string username, string paswword)
        {
            bool isCorrectCredential = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_LoginByUsernameAndPassword";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", paswword);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isCorrectCredential = true;
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


            return isCorrectCredential;
        }



        public static bool findLibraryManagerByUsername(ref int libraryManagerID , ref int personID , string username , ref string password ,ref  bool isActive )
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindLibraryManagerByUsername";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username",username);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read()) 
                { 
                    isFound = true;

                    libraryManagerID = (int)reader["ManagerID"];
                    personID = (int)reader["PersonID"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }


            return isFound;
        }



    }
}
