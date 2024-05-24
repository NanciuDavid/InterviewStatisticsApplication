using System.Configuration;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using Dapper;

namespace PROIECTWAP.Classes
{
    public class SqliteDataAccess
    {

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //method called InsertPerson that takes a Person object as a parameter and saves it in the db
        public static void InsertPerson(Person person)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Person (Name, PhoneNumber, Address, Age, Gender) values (@Name, @PhoneNumber, @Address, @Age, @Gender)", person);
            }

        }

        public static void InsertInterview(Interview interview)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Interview (Duration, Time, Location, Result) values (@Duration, @Time, @Location, @Result)", interview);
            }
        }

        //do the same for AnalysisResult
        public static void InsertAnalysisResults(AnalysisResult analysisResults)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into AnalysisResult (Department, TotalInterviews, TotalAccepted, TotalRejected) values (@Department, @TotalInterviews, @TotalAccepted, @TotalRejected)", analysisResults);
            }
        }
       
    }
          
}
   

    

