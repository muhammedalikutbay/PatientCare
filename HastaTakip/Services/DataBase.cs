using System.Data.SQLite;
using System.Configuration;

namespace HastaTakip.Services
{
    public static partial class DataTables
    {
        private static string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

        private static void Patients()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createTableQuery =
                    @"
                      CREATE TABLE IF NOT EXISTS Patients(
                          ""Id""	INTEGER,
	                      ""OwnerId""	INTEGER,
	                      ""PatientName""	TEXT,
	                      ""PatientGender""	TEXT,
	                      ""RegistrationDate""	TEXT,
	                      ""PatientNote""	TEXT,

	                      PRIMARY KEY(""Id""),
	                      FOREIGN KEY(""OwnerId"") REFERENCES ""PatientsOwner""(""Id"")
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void PatientsOwner()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createTableQuery =
                    @"
                      CREATE TABLE IF NOT EXISTS PatientsOwner(
                            ""Id""	INTEGER,
	                        ""OwnerName""	TEXT,
	                        ""OwnerAdress""	TEXT,
	                        ""OwnerPhone""	INTEGER,

	                        PRIMARY KEY(""Id"")
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void Treatments()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createTableQuery =
                    @"
                      CREATE TABLE IF NOT EXISTS Treatments(
	                    ""Id""	INTEGER,
	                    ""PatientId""	INTEGER,
	                    "" TreatmentDate""	DATETIME,
	                    ""Diagnosis""	TEXT,
	                    "" TreatmentDetails""	TEXT,

	                    PRIMARY KEY(""Id""),
	                    FOREIGN KEY(""PatientId"") REFERENCES ""Patients""(""Id"")
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void CreateTables()
        {
            Treatments();
            PatientsOwner();
            Patients();
        }
    }
}
