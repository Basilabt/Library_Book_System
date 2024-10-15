using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCardDataAccess
    {
           
    public static DataTable getAllCards()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_GetAllCards";
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


            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }





            return dataTable;

        }



        public static bool doesCardExistByFullname(string fullname)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DoesCardExistByFullname";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FullName", fullname);
            

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
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

        public static bool findCardByCardNumber(ref int cardID , ref int userID , string cardNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection (clsDataAccessLayerSettings.connectionString);

            string query = "SP_FindCardByCardNumber";
            SqlCommand command = new SqlCommand (query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CardNumber", cardNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    cardID = (int)reader["CardID"];
                    userID = (int)reader["UserID"];
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

        public static bool deleteCardByCardNumber(string cardNumber)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_DeleteCardByCardNumber";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CardNumber", cardNumber);

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

        public static bool isUniqueCardNumber(string cardNumber)
        {
            bool isUnique = true;

            SqlConnection connection = new SqlConnection (clsDataAccessLayerSettings.connectionString);

            string query = "SP_IsUniqueCardNumber";
            SqlCommand command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CardNumber", cardNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    isUnique = false;
                }


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }




            return isUnique;
        }


        public static int addNewCard(int userID , string cardNumber)
        {
            int newCardID = -1;
            
            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString);

            string query = "SP_AddNewCard";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@CardNumber", cardNumber);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newCardID = id;
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


            return newCardID;
        }

    }
}
