using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HastaTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);  // Form yüklendiğinde çalışacak event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // SQLite veritabanı dosyasını oluşturma
                string connectionString = "Data Source=ClientFollow.db;Version=3;";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteConnection.ClearAllPools();

                    // User tablosunu oluştur
                    string createTableQuery = @"
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
                        cmd.ExecuteNonQuery();  // Sorguyu çalıştır
                    }

                    MessageBox.Show("Veritabanı ve tablo başarıyla oluşturuldu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
