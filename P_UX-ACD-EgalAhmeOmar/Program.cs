using P_UX_ACD_EgalAhmeOmar.Controller;
using P_UX_ACD_EgalAhmeOmar.Views;
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

            ViewbillOrnot viewbillOrnot = new ViewbillOrnot();

            ViewmyAllchoices viewmyAllchoices = new ViewmyAllchoices();

            ViewnormalTicketchoices viewNormalticketChoices = new ViewnormalTicketchoices();

            ViewselectNavigoorNot viewselectNavigoorNot = new ViewselectNavigoorNot();

            ViewselectPaymentmethod viewselectPaymentmethod = new ViewselectPaymentmethod();

            ViewselectSpecialorNormaltickets viewselectSpecialorNormaltickets = new ViewselectSpecialorNormaltickets();

            ViewselectSpecialtickets viewselectSpecialtickets = new ViewselectSpecialtickets();

            ViewspecialTicketchoices viewspecialTicketchoices = new ViewspecialTicketchoices();

            Model.Model model = new Model.Model();

            Controller.Controller controller = new Controller.Controller(view, model, viewselectPaymentmethod, viewselectSpecialorNormaltickets, viewselectSpecialtickets, viewbillOrnot, viewmyAllchoices, 
                viewNormalticketChoices, viewselectNavigoorNot, viewspecialTicketchoices);

            Application.Run(view);
        }
    }
}
