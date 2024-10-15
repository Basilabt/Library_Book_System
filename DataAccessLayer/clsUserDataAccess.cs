using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsUserDataAccess
    {

        public static DataTable getAllUsers()
        {
            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);
            string query = "SP_GetAllUsers";
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

                Console.WriteLine("DEBUG: {0}",exception.Message);

            }
             finally
            {
                connection.Close();
            }




            return dataTable;
        }

        public static bool findUserByPhoneNumber(string phoneNumber,ref int userID , ref int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindUserByPhoneNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PhoneNumber",phoneNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
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

        public static bool findUserByID(int userID , ref int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindUserByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["PersonID"];
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

    
        public static int addNewUser(int personID)
        {
            int newUserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewUser";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newUserID = id;
                }


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }




            return newUserID;
        }

        public static  bool deleteUserByID(int userID)
        {
            // Person associated with this user will be deleted at DB Level using After delete trigger.
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteUserByID";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();

            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }
            
            return numberOfAffectedRows >= 1;
        }




    }
}
