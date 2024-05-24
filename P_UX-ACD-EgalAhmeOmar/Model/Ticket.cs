using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_UX_ACD_EgalAhmeOmar.Model
{
    public class Ticket
    {
        // Liste privée pour stocker les prix des billets.
        private double _price = 0.00;
        // Propriété publique pour accéder et modifier la liste des soldes.
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        //
        private string _name = "";
        //
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //
        private DateTime _created = DateTime.Now;
        //
        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="name"></param>
        /// <param name="created"></param>
        public Ticket(double price ,string name, DateTime created) 
        {
            _price = price;
            _name = name;
            _created = created; 
        }

    }
}
