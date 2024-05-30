///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans le modèle qui contient 
///l'ensemble des valeurs des billets de la RATP ainsi que la liste de tickets de l'utilisateur.
///**************************************************************************************
using System.Collections.Generic;

// Importer les éléments visuels de la bibliothèque de styles visuels de Windows Forms

namespace P_UX_ACD_EgalAhmeOmar.Model
{
    // Cette classe représente le modèle de données de l'application
    public class Model
    {
        // Prix d'un billet standard
        private int _priceStandardticket = 2;

        // Propriété publique permettant d'accéder au prix d'un billet standard
        public int PriceStandardTicket
        {
            get { return _priceStandardticket; }
            set { _priceStandardticket = value; }
        }

        // Prix d'un billet réduit
        private double _priceReducedticket = 1.75;

        // Propriété publique permettant d'accéder au prix d'un billet réduit
        public double PriceReducedticket
        {
            get { return _priceReducedticket; }
            set { _priceReducedticket = value; }
        }

        // Prix d'un billet pour le parc Disney à Chessy
        private int _pricesChessyDisneyticketOne = 40;

        // Propriété publique permettant d'accéder au prix d'un billet pour le parc Disney à Chessy
        public int PricesChessyDisneyticketOne
        {
            get { return _pricesChessyDisneyticketOne; }
            set { _pricesChessyDisneyticketOne = value; }
        }

        // Prix d'un billet pour l'aéroport
        private int _pricesAirportyticketOne = 30;

        // Propriété publique permettant d'accéder au prix d'un billet pour l'aéroport
        public int PricesAirportyticketOne
        {
            get { return _pricesAirportyticketOne; }
            set { _pricesAirportyticketOne = value; }
        }

        // Prix d'un billet pour la visite de Paris
        private int _pricesParisVisiteticketOne = 15;

        // Propriété publique permettant d'accéder au prix d'un billet pour la visite de Paris
        public int PricesParisVisiteticketOne
        {
            get { return _pricesParisVisiteticketOne; }
            set { _pricesParisVisiteticketOne = value; }
        }

        // Nom d'un billet pour le parc Disney à Chessy
        private string _nameChessyDisneyticket = "";

        // Propriété publique permettant d'accéder au nom d'un billet pour le parc Disney à Chessy
        public string NameChessyDisneyticket
        {
            get { return _nameChessyDisneyticket; }
            set { _nameChessyDisneyticket = value; }
        }

        // Nom d'un billet pour l'aéroport
        private string _nameAirporticket = "";

        // Propriété publique permettant d'accéder au nom d'un billet pour l'aéroport
        public string NameAirportyticket
        {
            get { return _nameAirporticket; }
            set { _nameAirporticket = value; }
        }

        // Nom d'un billet pour la visite de Paris
        private string _nameParisVisiteticket = "";

        // Propriété publique permettant d'accéder au nom d'un billet pour la visite de Paris
        public string NameParisVisiteticket
        {
            get { return _nameParisVisiteticket; }
            set { _nameParisVisiteticket = value; }
        }

        // Nom d'un billet réduit
        private string _nameReducedticket = "";

        // Propriété publique permettant d'accéder au nom d'un billet réduit
        public string NameReducedticket
        {
            get { return _nameReducedticket; }
            set { _nameReducedticket = value; }
        }

        // Nom d'un billet standard
        private string _nameStandardticket = "";

        // Propriété publique permettant d'accéder au nom d'un billet standard
        public string NameStandardticket
        {
            get { return _nameStandardticket; }
            set { _nameStandardticket = value; }
        }

        // Solde actuel
        private int _balance = 0;

        // Propriété publique permettant d'accéder au solde actuel
        public int Balance { get { return _balance; } set { _balance = value; } }

        // Liste des billets
        private List<Ticket> _tickets = new List<Ticket>();

        // Propriété publique permettant d'accéder à la liste des billets
        public List<Ticket> Tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }

        // Contrôleur associé à ce modèle
        public Controller.Controller Controller { get; set; }

        // Constructeur par défaut
        public Model()
        {

        }
    }
}
