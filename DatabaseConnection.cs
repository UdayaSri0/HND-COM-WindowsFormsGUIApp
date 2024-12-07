using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGUIApp
{
    internal class DatabaseConnection
    {

        // Connection string for the database
        private static readonly string ConnectionString = @"Data Source=darkstar;Initial Catalog=WindowsFormsGUIApp;Integrated Security=True;Encrypt=False";

        /// <summary>
        /// Provides a new SQL connection.
        /// </summary>
        /// <returns>SqlConnection object</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        /// <summary>
        /// Executes a non-query SQL command (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">SQL command text</param>
        /// <param name="parameters">SQL parameters</param>
        /// <returns>Number of rows affected</returns>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open(); // Open connection here
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    return cmd.ExecuteNonQuery();
                }
            } // Connection is automatically closed and disposed here
        }

        /// <summary>
        /// Executes a scalar SQL command (returns a single value, e.g., COUNT, MAX).
        /// </summary>
        /// <param name="query">SQL command text</param>
        /// <param name="parameters">SQL parameters</param>
        /// <returns>Result object</returns>
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open(); // Open connection here
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    return cmd.ExecuteScalar();
                }
            } // Connection is automatically closed and disposed here
        }

        /// <summary>
        /// Executes a SQL query and returns a DataTable.
        /// </summary>
        /// <param name="query">SQL query text</param>
        /// <param name="parameters">SQL parameters</param>
        /// <returns>DataTable containing the result set</returns>
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open(); // Open connection here
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            } // Connection is automatically closed and disposed here
        }
    }
}
