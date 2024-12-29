using System;
using System.Windows.Forms;
using Handlers;
using HastaTakip.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HastaTakip
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ExceptionHandler.HandleThreadException;
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler.HandleUnhandledException;

            var serviceProvider = new ServiceCollection()
                .AddDatabaseService() 
                .BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var databaseService = serviceProvider.GetService<IDatabaseService>();
            var starterPack = new StarterPack(databaseService); 
            starterPack.Start();

            Application.Run(new Form1());


        }
    }
}
