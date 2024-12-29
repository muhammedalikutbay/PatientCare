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
            DataTables.CreateTables();
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
