using System;
using System.Windows.Forms;

namespace HastaTakip.Handler
{
    public static class ExceptionHandler
    {
        public static void HandleThreadException(
            object sender,
            System.Threading.ThreadExceptionEventArgs e
        )
        {
            MessageBox.Show(
                "Arayüzde bir hata oluştu.",
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            Console.WriteLine($"Arayüzde bir hata oluştu: \n \n {e.Exception}");
        }

        public static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(
                "Serviste bir hata oluştu. Uygulama kapatılacak.",
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            if (e.ExceptionObject is Exception ex)
            {
                Console.WriteLine($"Serviste bir hata oluştu: \n \n {ex}");
            }
            else
            {
                Console.WriteLine($"Serviste bir hata oluştu: \n \n {e.ExceptionObject}");
            }
        }
    }
}
