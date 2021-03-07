    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eleições_2020.Models;
using Eleições_2020.Views;

namespace Eleições_2020
{
    static class Program
    {
        public static List<Candidato> candidatosList = new List<Candidato>();
    
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telaMenu());
        }
    }
}
