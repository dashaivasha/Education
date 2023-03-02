using Dapper;
using dbtask.TestData;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace dbtask.DBServiсe
{
    public class DbConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DbConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = TestingData.Server;
            database = TestingData.DbName;
            uid = TestingData.Login;
            password = TestingData.Password;
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            connection = new MySqlConnection(connectionString);
        }

        private bool TryOpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool TryCloseConnection()
        {
            try
            {
                ConnectionState state = connection.State;
                if (state == ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<T> RunQuery<T>(string query)
        {
            TryOpenConnection();
            List<T> result = connection.Query<T>(query).AsList();
            TryCloseConnection();

            return result;
        }
    }
}


