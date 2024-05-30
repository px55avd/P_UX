///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans le classe Program
///qui contient l'ensemble des instanciation des vues, modèle et vues. elle lance la première au 
///démarrage de l'application.
///**************************************************************************************
using P_UX_ACD_EgalAhmeOmar.Views;
using System;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar
{
    public static class Program
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
