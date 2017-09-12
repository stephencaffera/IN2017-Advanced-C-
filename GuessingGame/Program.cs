using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public static int RandomNumber()
        {
            Random RandomNumberGenerator = new Random();
            int RandomNumber = RandomNumberGenerator.Next(1, 11);
            return RandomNumber;
        }
    }
}
