using System.Data.SQLite;

namespace HastaTakip.Services
{
    public static partial class DataTables
    {
        private static string ConnectionString { get; set; } =
            "Data Source=PatientFalllow.db;Version=3;";

        private static void Patients()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // User tablosunu oluştur
                string createTableQuery =
                    @"
                  CREATE TABLE IF NOT EXISTS Patients(
                      ""PatientId""	INTEGER,
	                  ""OwnerId""	INTEGER,
	                  ""PatientName""	BLOB,
	                  ""PatientGender""	TEXT,
	                  ""RegistrationDate""	DATETIME,
	                  ""PatientNote""	TEXT,
	                  PRIMARY KEY(""PatientId""),
	                  FOREIGN KEY(""OwnerId"") REFERENCES ""PatientOwners""(""PatientOwnerId"")
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                }
            }
        }

        private static void PatientsOwner()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // User tablosunu oluştur
                string createTableQuery =
                    @"
                  CREATE TABLE IF NOT EXISTS PatientsOwner(
                        ""PatientOwnerId""	INTEGER,
	                    ""OwnerName""	TEXT,
	                    ""OwnerAdress""	TEXT,
	                    ""OwnerPhone""	INTEGER,
	                    PRIMARY KEY(""PatientOwnerId"")
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                }
            }
        }

        private static void Treatments()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // User tablosunu oluştur
                string createTableQuery =
                    @"
                  CREATE TABLE IF NOT EXISTS Treatments(
	                ""TreatmentID ""	INTEGER,
	                ""PatientID ""	INTEGER,
	                "" TreatmentDate""	DATETIME,
	                ""Diagnosis ""	TEXT,
	                "" TreatmentDetails""	TEXT,
	                PRIMARY KEY(""TreatmentID ""),
	                FOREIGN KEY(""PatientID "") REFERENCES ""Patients""(""PatientId"")
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
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
