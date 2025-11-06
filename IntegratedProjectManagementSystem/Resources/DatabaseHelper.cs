using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedProjectManagementSystem.Resources
{
    public class DatabaseHelper
    {

        // CHANGE CONNECTION STRING BASED ON YOUR DB CONFIGURATION
        private static string connectionString = @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;Initial Catalog=BLFDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // SAMPLE USE IN OTHER FORMS

        /*
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                // Your SQL operations here
            }

        USE THIS METHOD TO GET CONNECTION IN OTHER CLASSES
        

        // RUN THIS IN SSMS TO CREATE DATABASE


            CREATE DATABASE BLFDB;
            GO

            USE BLFDB;
            GO

            CREATE TABLE Users (
                userId INT IDENTITY(1,1) PRIMARY KEY,
                username NVARCHAR(50) NOT NULL UNIQUE,
                password NVARCHAR(255) NOT NULL,
                role NVARCHAR(50) NOT NULL,
                isActive BIT NOT NULL DEFAULT 1
            );
            GO

            INSERT INTO Users (username, password, role, isActive) VALUES 
            ('admin', 'admin123', 'Administrator', 1),
            ('user', 'user123', 'User', 1);


        */


        // IS USED IN LOGIN FORM TO VALIDATE USERS
        public static bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password AND isActive = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int result = (int)command.ExecuteScalar();
                return result > 0;
            }
        }

        public static string GetUserRole(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT role FROM Users WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                return command.ExecuteScalar()?.ToString();
            }
        }
    }
}
