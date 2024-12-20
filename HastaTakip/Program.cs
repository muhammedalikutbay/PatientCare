using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using HastaTakip.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using HastaTakip.Services;



namespace HastaTakip
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // DI Container kurulumunu yapıyoruz ve ServiceCollectionExtention sınıfındaki extension method'u çağırıyoruz
            var serviceProvider = new ServiceCollection()
                .AddDatabaseService()  // Extension method ile DatabaseService ekliyoruz
                .BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // StarterPack sınıfını alıyoruz ve Start() metodunu çalıştırıyoruz
            var databaseService = serviceProvider.GetService<IDatabaseService>();
            var starterPack = new StarterPack(databaseService);  // IDatabaseService enjekte ediliyor
            starterPack.Start();  // Start metodunu çağırıyoruz

            Application.Run(new Form1());
        }
    }
}
