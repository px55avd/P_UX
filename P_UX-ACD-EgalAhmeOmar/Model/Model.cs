using P_UX_ACD_EgalAhmeOmar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P_UX_ACD_EgalAhmeOmar.Model
{
    public class Model
    {
        //
        private int _priceStandardticket = 2;
        //
        public int PriceStandardTicket
        {
            get { return _priceStandardticket; }
            set { _priceStandardticket = value; }
        }

        //
        private int _pricesChessyDisneyticketOne = 10;
        //
        public int PricesChessyDisneyticketOne
        {
            get { return _pricesChessyDisneyticketOne; }
            set { _pricesChessyDisneyticketOne = value; }
        }


        //
        private int _balance = 0;
        //
        public int Balance { get { return _balance; } set{ _balance = value; } }

        //
        private List<Ticket> _tickets = new List<Ticket>();
        //
        public List<Ticket> Tickets
        {
            get {  return _tickets; }
            set { _tickets = value; }
        }

        public Controller.Controller Controller { get; set; }

        public Model() 
        {
            // Appel de la méthode pour initialiser les données.
            initialasing();
        }

        /// <summary>
        /// // Méthode pour initialiser les données du modèle.
        /// </summary>
        public void initialasing()
        {
            

        }
    }
}
