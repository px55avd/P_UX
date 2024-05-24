using P_UX_ACD_EgalAhmeOmar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
        private double _priceReducedticket = 1.75;
        //
        public double PriceReducedticket
        {
            get { return _priceReducedticket; }
            set { _priceReducedticket = value; }
        }

        //
        private int _pricesChessyDisneyticketOne = 40;
        //
        public int PricesChessyDisneyticketOne
        {
            get { return _pricesChessyDisneyticketOne; }
            set { _pricesChessyDisneyticketOne = value; }
        }

        private int _pricesAirportyticketOne = 30;
        //
        public int PricesAirportyticketOne
        {
            get { return _pricesAirportyticketOne; }
            set { _pricesAirportyticketOne = value; }
        }

        //
        private int _pricesParisVisiteticketOne = 15;
        //
        public int PricesParisVisiteticketOne
        {
            get { return _pricesParisVisiteticketOne; }
            set { _pricesParisVisiteticketOne = value; }
        }

        //
        private string _nameChessyDisneyticket = "";
        //
        public string NameChessyDisneyticket
        {
            get { return _nameChessyDisneyticket; }
            set { _nameChessyDisneyticket = value; }
        }

        //
        private string _nameAirporticket = "";
        //
        public string NameAirportyticket
        {
            get { return _nameAirporticket; }
            set { _nameAirporticket = value; }
        }

        //
        private string _nameParisVisiteticket = "";
        //
        public string NameParisVisiteticket
        {
            get { return _nameParisVisiteticket; }
            set { _nameParisVisiteticket = value; }
        }

        //
        private string _nameReducedticket = "";
        //
        public string NameReducedticket
        {
            get { return _nameReducedticket; }
            set { _nameReducedticket = value; }
        }

        private string _nameStandardticket = "";
        //
        public string NameStandardticket
        {
            get { return _nameStandardticket; }
            set { _nameStandardticket = value; }
        }


        //
        private int _balance = 0;
        //
        public int Balance { get { return _balance; } set { _balance = value; } }

        //
        private List<Ticket> _tickets = new List<Ticket>();
        //
        public List<Ticket> Tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }

        public Controller.Controller Controller { get; set; }

        public Model()
        {

        }


    }
}
