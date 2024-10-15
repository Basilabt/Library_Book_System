using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsFineDataAccess
    {
        public static DataTable getAllFines()
        {
            DataTable dataTable = new DataTable();

            try
            {

                using(SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();

                    string query = "SP_GetAllFines";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {

                            if(reader.HasRows)
                            {
                                dataTable.Load(reader);

                            }

                        }

                    }

                }


            } catch(Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);
            }


            return dataTable;
        }

        public static bool deleteFineByFineID(int fineID)
        {
            int numberOfAffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.connectionString))
                {
                   connection.Open();


                   string query = "SP_DeleteFineByFineID";
                   using(SqlCommand command = new SqlCommand(query,connection))
                   {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FineID", fineID);

                        numberOfAffectedRows = command.ExecuteNonQuery();

                    }

                }

            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);
            }

            return numberOfAffectedRows >= 1;
        }

        public static bool markFineIsPaidByFineID(int fineID)
        {
            int numberOfAffectedRows = 0;

            try
            {
                
                using(SqlConnection connection = new SqlConnection (clsDataAccessLayerSettings.connectionString))
                {
                    connection.Open();


                    string query = "SP_MarkFineAsPaidByFineID";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FineID", fineID);

                        numberOfAffectedRows = command.ExecuteNonQuery();

                    }

                }



            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}", exception.Message);
            }


            return numberOfAffectedRows >= 1;
        }

    }



}
