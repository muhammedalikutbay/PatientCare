using System;
using System.Data.SQLite;
using System.Windows.Forms;
using HastaTakip.Interfaces;

namespace HastaTakip.Services
{
    internal class DatabaseService : IDatabaseService
    {
        public void CreateDatabase()
        {
            // SQLite veritabanı dosyasını oluşturma
            string connectionString = "Data Source=ClientFollow.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // User tablosunu oluştur
                string createTableQuery =
                    @"
                  CREATE TABLE IF NOT EXISTS Client(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ClientOwner TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        Client TEXT NOT NULL,
                        ClientType TEXT NOT NULL,
                        Gender INTEGER CHECK(Gender IN (1, 0)),
                        Cure TEXT NULL,
                        EstablishTime DATETIME NULL,
                        Notes TEXT NULL
                    );";
                ;

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                }
            }
        }

        public void CreateTables()
        {
            throw new System.NotImplementedException();
        }

        public void InsertSampleData()
        {
            throw new System.NotImplementedException();
        }
    }
}
