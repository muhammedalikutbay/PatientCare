using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HastaTakip.Interfaces;
using HastaTakip.Services;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HastaTakip
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            // DI Container kurulumunu yapıyoruz ve ServiceCollectionExtention sınıfındaki extension method'u çağırıyoruz
            var serviceProvider = new ServiceCollection()
                .AddDatabaseService() // Extension method ile DatabaseService ekliyoruz
                .BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // StarterPack sınıfını alıyoruz ve Start() metodunu çalıştırıyoruz
            var databaseService = serviceProvider.GetService<IDatabaseService>();
            var starterPack = new StarterPack(databaseService); // IDatabaseService enjekte ediliyor
            starterPack.Start(); // Start metodunu çağırıyoruz

            Application.Run(new Form1());
        }

        private static void Application_ThreadException(
            object sender,
            System.Threading.ThreadExceptionEventArgs e
        )
        {
            MessageBox.Show(
                "Bir hata oluştu.",
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private static void CurrentDomain_UnhandledException(
            object sender,
            UnhandledExceptionEventArgs e
        )
        {
            MessageBox.Show(
                "Kritik bir hata oluştu. Uygulama kapatılacak.",
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            Console.WriteLine("Hata Burdan Başlyor amk: \n \n\n",e);
           
        }
    }
}
