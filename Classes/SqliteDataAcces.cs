using System.Data.SQLite;

namespace PROIECTWAP.Classes
{
    internal class SqliteDataAccess
    {
        private string connectionString;

        public SqliteDataAccess(string dbFilePath)
        {
            // Set connection string using the provided database file path
            connectionString = $"Data Source={dbFilePath};Version=3;";
        }

        public void CreateDatabase()
        {
            SQLiteConnection.CreateFile(connectionString);
        }

        public void DeleteDatabase(string dbFilePath)
        {
            if (System.IO.File.Exists(dbFilePath))
            {
                System.IO.File.Delete(dbFilePath);
            }
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        // Insert data into the database 
        public void InsertAnalysisResult(AnalysisResult result)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"INSERT INTO AnalysisResult (Department, TotalInterviews, TotalAccepted, TotalRejected, AcceptanceRate, RejectionRate)
                                       VALUES (@Department, @TotalInterviews, @TotalAccepted, @TotalRejected, @AcceptanceRate, @RejectionRate);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Department", result.Department);
                    command.Parameters.AddWithValue("@TotalInterviews", result.TotalInterviews);
                    command.Parameters.AddWithValue("@TotalAccepted", result.TotalAccepted);
                    command.Parameters.AddWithValue("@TotalRejected", result.TotalRejected);
                    command.Parameters.AddWithValue("@AcceptanceRate", result.AcceptanceRate);
                    command.Parameters.AddWithValue("@RejectionRate", result.RejectionRate);

                    command.ExecuteNonQuery();
                }
            }
        }

        // InsertPerson method
        public void InsertPerson(Person person)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"INSERT INTO Person (Name, PhoneNumber, Address, Age, Gender)
                                       VALUES (@Name, @PhoneNumber, @Address, @Age, @Gender);";
                //complete the query
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", person.Name);
                    command.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", person.Address);
                    command.Parameters.AddWithValue("@Age", person.Age);
                    command.Parameters.AddWithValue("@Gender", person.Gender);
                }
            }
        }

        //InsertInterview method
        public void InsertInterview(Interview interview)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"INSERT INTO Interview (ID, Duration, Date, Location, Result)
                                       VALUES (@ID, @Duration, @Time, @Location, @Result);";
                //complete the query
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", interview.ID);
                    command.Parameters.AddWithValue("@Duration", interview.Duration);
                    command.Parameters.AddWithValue("@Location", interview.Location);
                    command.Parameters.AddWithValue("@Result", interview.Result);
                }
            }
        }

    }
    //create the  method LoadAnalysisResults used to retrieve data from db into datagridview

}
