using P_UX_ACD_EgalAhmeOmar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            View view = new View();

            Model.Model model = new Model.Model();

            Controller.Controller controller = new Controller.Controller(view, model);

            Application.Run(view);

            
        }
    }
}
