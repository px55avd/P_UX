///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans une class Ticket
///qui se trouve dans le repertoire Model. La class Ticket sert a optimiser la gstion des tickets
///**************************************************************************************
using System;

namespace P_UX_ACD_EgalAhmeOmar.Model
{
    // Cette classe représente un billet dans le système
    public class Ticket
    {
        // Prix du billet
        private double _price = 0.00;

        // Propriété publique pour accéder et modifier le prix du billet
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // Nom du billet
        private string _name = "";

        // Propriété publique pour accéder et modifier le nom du billet
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Date de création du billet
        private DateTime _created = DateTime.Now;

        // Propriété publique pour accéder et modifier la date de création du billet
        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        // Constructeur de la classe Ticket
        public Ticket(double price, string name, DateTime created)
        {
            // Initialiser les valeurs du billet avec les valeurs fournies en paramètres
            _price = price;
            _name = name;
            _created = created;
        }
    }
}
