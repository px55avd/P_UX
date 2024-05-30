///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans le controleur
///qui gère les interection entre les différentes vues et le modèle et la classe Ticket.cs.
///**************************************************************************************
using P_UX_ACD_EgalAhmeOmar.Model;
using P_UX_ACD_EgalAhmeOmar.Views;
using System;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar.Controller
{
    public class Controller
    {
        // Déclarations des différentes vues utilisées par le contrôleur.
        private View _view;
        private ViewbillOrnot _viewBillorNot;
        private ViewmyAllchoices _viewMyallChoices;
        private ViewnormalTicketchoices _viewNormalticketChoices;
        private ViewselectNavigoorNot _viewSelectnavigoOrnot;
        private ViewselectPaymentmethod _viewSelectpaymentMethod;
        private ViewselectSpecialorNormaltickets _viewSelectspecialorNormaltickets;
        private ViewselectSpecialtickets _viewSelectspecialtickets;
        private ViewspecialTicketchoices _viewSpecialticketsChoices;

        // Référence au modèle utilisé par le contrôleur.
        private Model.Model _model;

        // Variables de contrôle pour les différents états de l'application.
        private int _specialOrnormalTickets = 0;
        private int _countNormalpriceTicket = 0;
        private int _countReducedpriceTicket = 0;
        private string _currentSpecialticket = "";
        private int _numberDayofspecialTicket = 0;

        // Enumération pour les langues disponibles.
        public enum Language { French, English, Spanish, Deutsh, Italian };

        // Langue actuelle de l'application.
        private Language _currentLanguage;

        // Gestionnaire de ressources pour la localisation.
        ResourceManager rManager = new ResourceManager(typeof(Ressources.French));

        /// <summary>
        /// Constructeur de la classe Controller.
        /// </summary>
        /// <param name="view">La vue principale de l'application.</param>
        /// <param name="model">Le modèle de données de l'application.</param>
        /// <param name="viewSelectpaymentMethod">La vue pour sélectionner la méthode de paiement.</param>
        /// <param name="viewSelectspecialorNormaltickets">La vue pour sélectionner les billets spéciaux ou normaux.</param>
        /// <param name="viewSelectspecialtickets">La vue pour sélectionner les billets spéciaux.</param>
        /// <param name="viewBillorNot">La vue pour afficher la facture ou non.</param>
        /// <param name="viewMyallChoices">La vue pour afficher toutes les options disponibles.</param>
        /// <param name="viewNormalticketChoices">La vue pour afficher les choix de billets normaux.</param>
        /// <param name="viewSelectnavigOornot">La vue pour choisir d'utiliser ou non un passe Navigo.</param>
        /// <param name="viewSpecialticketChoices">La vue pour afficher les choix de billets spéciaux.</param>
        public Controller(View view, Model.Model model, ViewselectPaymentmethod viewSelectpaymentMethod, 
            ViewselectSpecialorNormaltickets viewSelectspecialorNormaltickets,ViewselectSpecialtickets viewSelectspecialtickets, ViewbillOrnot viewBillorNot,
            ViewmyAllchoices viewMyallChoices, ViewnormalTicketchoices viewNormalticketChoices,ViewselectNavigoorNot viewSelectnavigOornot,
            ViewspecialTicketchoices viewSpecialticketChoices)
        {
            // Initialisation des références aux vues et au modèle.
            _model = model;
            _model.Controller = this;

            // Vue principale
            _view = view;
            _view.Controller = this;

            // Vue pour sélectionner la méthode de paiement.
            _viewSelectpaymentMethod = viewSelectpaymentMethod;
            _viewSelectpaymentMethod.Controller = this;

            // Vue pour sélectionner les billets spéciaux ou normaux.
            _viewSelectspecialorNormaltickets = viewSelectspecialorNormaltickets;
            _viewSelectspecialorNormaltickets.Controller = this;

            // Vue pour sélectionner les billets spéciaux.
            _viewSelectspecialtickets = viewSelectspecialtickets;
            _viewSelectspecialtickets.Controller = this;

            // Vue pour afficher la facture ou non.
            _viewBillorNot = viewBillorNot;
            _viewBillorNot.Controller = this;

            // Vue pour afficher toutes les options disponibles.
            _viewMyallChoices = viewMyallChoices;
            _viewMyallChoices.Controller = this;

            // Vue pour afficher les choix de billets normaux.
            _viewNormalticketChoices = viewNormalticketChoices;
            _viewNormalticketChoices.Controller = this;

            // Vue pour afficher les choix de billets spéciaux.
            _viewSpecialticketsChoices = viewSpecialticketChoices;
            _viewSpecialticketsChoices.Controller = this;

            // Vue pour choisir d'utiliser ou non un passe Navigo.
            _viewSelectnavigoOrnot = viewSelectnavigOornot;
            _viewSelectnavigoOrnot.Controller = this;
        }


        /// <summary>
        /// Masque une fenêtre et affiche une autre.
        /// </summary>
        /// <param name="hide">La fenêtre à masquer.</param>
        /// <param name="show">La fenêtre à afficher.</param>
        public void HideShow(Form hide, Form show)
        {
            hide.Hide();
            show.Show();
        }

        /// <summary>
        /// Affiche la vue pour choisir d'utiliser ou non un passe Navigo.
        /// </summary>
        public void ShowViewselectNavigoOrnot()
        {
            HideShow(_view, _viewSelectnavigoOrnot);
        }

        /// <summary>
        /// Affiche la vue pour choisir les billets spéciaux.
        /// </summary>
        public void ShowViewselectSpecialtickets()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewSelectspecialtickets);
        }

        /// <summary>
        /// Affiche la vue pour choisir parmi les billets spéciaux.
        /// </summary>
        public void ShowViewSpecialticketChoices()
        {
            HideShow(_viewSelectspecialtickets, _viewSpecialticketsChoices);
        }

        /// <summary>
        /// Affiche la vue pour choisir un billet spécial.
        /// </summary>
        public void ShowViewselectSpecialticket()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewSelectspecialtickets);
        }

        /// <summary>
        /// Affiche la vue pour choisir entre les billets spéciaux et les billets normaux.
        /// </summary>
        public void ShowViewselectSpecialorNormaltickets()
        {
            HideShow(_viewSelectnavigoOrnot, _viewSelectspecialorNormaltickets);
        }

        /// <summary>
        /// Affiche la vue pour choisir parmi les options de billets spéciaux.
        /// </summary>
        public void ShowViewallMychoicestoViewspecialTicketChoices()
        {
            HideShow(_viewSpecialticketsChoices, _viewMyallChoices);
            _specialOrnormalTickets = 2;
        }

        /// <summary>
        /// Affiche la vue pour choisir la méthode de paiement.
        /// </summary>
        public void ShowViewselectPaymentMethod()
        {
            HideShow(_viewMyallChoices, _viewSelectpaymentMethod);
        }

        /// <summary>
        /// Affiche la vue pour choisir d'afficher ou non la facture.
        /// </summary>
        public void ShowViewbillOrnot()
        {
            HideShow(_viewSelectpaymentMethod, _viewBillorNot);
        }

        /// <summary>
        /// Affiche la vue pour choisir parmi les options de billets normaux.
        /// </summary>
        public void ShowViewnormalTicketChoices()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewNormalticketChoices);
        }

        /// <summary>
        /// Affiche la vue pour afficher toutes les options de billets normaux.
        /// </summary>
        public void ShowViewallMychoicestoViewnormalTicketChoices()
        {
            HideShow(_viewNormalticketChoices, _viewMyallChoices);
            _specialOrnormalTickets = 1;
        }

        /// <summary>
        /// Affiche la vue pour choisir d'afficher ou non la facture.
        /// </summary>
        public void ShowViewtoViewbillOrnot()
        {
            HideShow(_viewBillorNot, _view);
        }

        /// <summary>
        /// Affiche la vue pour choisir la méthode de paiement.
        /// </summary>
        public void ShowViewtoViewselectPaymentMethod()
        {
            HideShow(_viewSelectpaymentMethod, _view);
        }

        /// <summary>
        /// Affiche la vue pour afficher toutes les options disponibles.
        /// </summary>
        public void ShowViewtoViewallMychoices()
        {
            HideShow(_viewMyallChoices, _view);
        }

        /// <summary>
        /// Affiche la vue pour choisir les billets spéciaux.
        /// </summary>
        public void ShowViewtoViewsSpecialticketChoices()
        {
            HideShow(_viewSpecialticketsChoices, _view);
        }

        /// <summary>
        /// Affiche la vue pour choisir les billets spéciaux ou normaux.
        /// </summary>
        public void ShowViewtoViewselectSpecialtickets()
        {
            HideShow(_viewSelectspecialtickets, _view);
        }

        /// <summary>
        /// Affiche la vue pour choisir d'utiliser ou non un passe Navigo.
        /// </summary>
        public void ShowViewtoViewselectNavigoOrnot()
        {
            HideShow(_viewSelectnavigoOrnot, _view);
        }

        /// <summary>
        /// Affiche la vue pour afficher toutes les options disponibles depuis la sélection des billets.
        /// </summary>
        public void ShowViewallmyChoicestoViewselectSpecialorNormaltickets()
        {
            HideShow(_viewMyallChoices, _viewSelectnavigoOrnot);
        }

        /// <summary>
        /// Affiche la vue pour choisir d'utiliser ou non un passe Navigo depuis la sélection des billets.
        /// </summary>
        public void ShowViewselectNavigoorNottoViewselectSpecialorNormaltickets()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewSelectnavigoOrnot);
        }

        /// <summary>
        /// Affiche la vue pour choisir entre les billets spéciaux et les billets normaux depuis la sélection des billets.
        /// </summary>
        public void ShowViewselectSpecialorNormalticketstoViewselectSpecialticket()
        {
            HideShow(_viewSelectspecialtickets, _viewSelectspecialorNormaltickets);
        }

        /// <summary>
        /// Affiche la vue pour choisir les billets spéciaux depuis la sélection des billets.
        /// </summary>
        public void ShowViewselectSpecialtickettoViewspecialTicketChoices()
        {
            HideShow(_viewSpecialticketsChoices, _viewSelectspecialtickets);
        }

        /// <summary>
        /// Affiche la vue pour choisir entre les billets spéciaux et les billets normaux depuis la sélection des billets.
        /// </summary>
        public void ShowViewselectSpecialorNormalticketstoViewnormalTicketChoices()
        {
            HideShow(_viewNormalticketChoices, _viewSelectspecialorNormaltickets);
        }

        /// <summary>
        /// Affiche la vue pour afficher toutes les options disponibles depuis la sélection de la méthode de paiement.
        /// </summary>
        public void ShowViewallMyChoicestoViewselectPaymentmethod()
        {
            HideShow(_viewSelectpaymentMethod, _viewMyallChoices);
        }

        /// <summary>
        /// Affiche la vue pour choisir entre les billets spéciaux et les billets normaux depuis l'affichage de toutes les options disponibles.
        /// </summary>
        public void ShowViewselectSpecialorNormaltickettoViewallMychoices()
        {
            HideShow(_viewMyallChoices, _viewSelectspecialorNormaltickets);
        }

        /// <summary>
        /// Affiche la vue des choix de billets spéciaux ou normaux dans la vue "Tous mes choix".
        /// </summary>
        public void ShowSpecialorNormalticketChoicestoViewallmyChoices()
        {
            // Vérifie si l'utilisateur a sélectionné des billets spéciaux.
            if (_specialOrnormalTickets == 1)
            {
                // Affiche la vue des choix de billets spéciaux.
                HideShow(_viewMyallChoices, _viewSpecialticketsChoices);
            }

            // Vérifie si l'utilisateur a sélectionné des billets normaux.
            if (_specialOrnormalTickets == 2)
            {
                // Affiche la vue des choix de billets normaux.
                HideShow(_viewMyallChoices, _viewNormalticketChoices);
            }
        }

        /// <summary>
        /// Affiche la vue avec un bouton "Stop" et réinitialise certaines variables.
        /// </summary>
        /// <param name="form">Le formulaire sur lequel la vue sera affichée.</param>
        public void ShowviewWithbtnStop(Form form)
        {
            // Appelle une méthode pour afficher/masquer une vue donnée sur le formulaire spécifié.
            HideShow(form, _view);

            // Réinitialise les variables en cours.
            _specialOrnormalTickets = 0;  // Réinitialise le nombre de billets spéciaux ou normaux.
            _countNormalpriceTicket = 0;  // Réinitialise le compteur de billets au prix normal.
            _countReducedpriceTicket = 0;  // Réinitialise le compteur de billets à prix réduit.
            _currentSpecialticket = "";  // Réinitialise le nom du billet spécial actuel.
            _numberDayofspecialTicket = 0;  // Réinitialise le nombre de jours pour les billets spéciaux.

            // Réinitialise la langue à la langue par défaut (français).
            _currentLanguage = Language.French;
        }

        /// <summary>
        /// Renvoie le nom du billet spécial actuellement sélectionné.
        /// </summary>
        /// <returns>Le nom du billet spécial actuellement sélectionné.</returns>
        public string SetcurrentSpecialticket()
        {
            return _currentSpecialticket;
        }

        /// <summary>
        /// Réinitialise le nom du billet spécial actuellement sélectionné en le définissant sur une valeur nulle.
        /// </summary>
        /// <returns>Une chaîne vide pour indiquer que le billet spécial actuellement sélectionné est nul.</returns>
        public string SetnullSpecialticket()
        {
            // Réinitialise le nom du billet spécial actuellement sélectionné en le définissant sur une valeur nulle.
            string value = "";
            return value;
        }

        /// <summary>
        /// Crée de nouveaux billets spéciaux en fonction de la durée spéciale (1, 3 ou 5 jours), du prix standard ou réduit, et de la date.
        /// </summary>
        /// <param name="oneDayspecialTicket">Indique si le billet spécial est pour une journée.</param>
        /// <param name="threeDayspecialTicket">Indique si le billet spécial est pour trois jours.</param>
        /// <param name="fiveDayspecialTicket">Indique si le billet spécial est pour cinq jours.</param>
        /// <param name="standardPrice">Indique si le prix du billet est standard.</param>
        /// <param name="reducedPrice">Indique si le prix du billet est réduit.</param>
        /// <param name="date">La date de création des billets.</param>
        public void GetnumberofSpecialTicket(bool oneDayspecialTicket, bool threeDayspecialTicket, bool fiveDayspecialTicket, bool standardPrice,
            bool reducedPrice, DateTime date)
        {
            // Vérifie si le prix du billet est standard.
            if (standardPrice)
            {
                // Vérifie si le billet spécial est pour une journée.
                if (oneDayspecialTicket)
                {
                    GetnewSpecialticket(date, 1, 1); // Création du billet pour une journée sans réduction.
                }
                // Vérifie si le billet spécial est pour trois jours.
                if (threeDayspecialTicket)
                {
                    GetnewSpecialticket(date, 1, 0.85); // Création du billet pour trois jours avec une réduction de 15%.
                }
                // Vérifie si le billet spécial est pour cinq jours.
                if (fiveDayspecialTicket)
                {
                    GetnewSpecialticket(date, 1, 0.75); // Création du billet pour cinq jours avec une réduction de 25%.
                }
            }

            // Vérifie si le prix du billet est réduit.
            if (reducedPrice)
            {
                // Vérifie si le billet spécial est pour une journée.
                if (oneDayspecialTicket)
                {
                    GetnewSpecialticket(date, 1, 0.75); // Création du billet réduit pour une journée avec une réduction de 25%.
                }
                // Vérifie si le billet spécial est pour trois jours.
                if (threeDayspecialTicket)
                {
                    GetnewSpecialticket(date, 1, 0.70); // Création du billet réduit pour trois jours avec une réduction de 30%.
                }
                // Vérifie si le billet spécial est pour cinq jours.
                if (fiveDayspecialTicket)
                {
                    GetnewSpecialticket(date, 1, 0.60); // Création du billet réduit pour cinq jours avec une réduction de 40%.
                }
            }
        }

        /// <summary>
        /// Vérifie si les radio boutons des billets spéciaux sont bien cochés.
        /// </summary>
        /// <param name="oneDayspecialTicket">Indique si le billet spécial est pour une journée.</param>
        /// <param name="threeDayspecialTicket">Indique si le billet spécial est pour trois jours.</param>
        /// <param name="fiveDayspecialTicket">Indique si le billet spécial est pour cinq jours.</param>
        /// <param name="standardPrice">Indique si le prix du billet est standard.</param>
        /// <param name="reducedPrice">Indique si le prix du billet est réduit.</param>
        /// <returns></returns>
        public bool CheckradioBtncontainZeroTicket(bool oneDayspecialTicket, bool threeDayspecialTicket, bool fiveDayspecialTicket, bool standardPrice,
            bool reducedPrice)
        {
            // Initialiser une variable booléenne pour indiquer si les radio boutons ne sont pas cochés.
            bool isRiht = false;

            //Vérifie si aucun radio button n'est activé.
            if (oneDayspecialTicket is false && threeDayspecialTicket is false && fiveDayspecialTicket is false)
            {
                // Si les deux valeurs sont zéro et définir isRight à true.
                isRiht = true;
            }
            if(standardPrice is false && reducedPrice is false)
            {
                // Si les deux valeurs sont zéro et définir isRight à true.
                isRiht = true;
            }


            // Retourner le résultat de la vérification.
            return isRiht;
        }

        /// <summary>
        /// Crée de nouveaux billets spéciaux en fonction du type de billet spécial actuel, de la date, du nombre de billets et du multiplicateur réduit.
        /// </summary>
        /// <param name="date">La date de création des billets.</param>
        /// <param name="numberTicket">Le nombre de billets à créer.</param>
        /// <param name="reducedMultiply">Le multiplicateur appliqué pour réduire le prix des billets.</param>
        public void GetnewSpecialticket(DateTime date, int numberTicket, double reducedMultiply)
        {
            // Vérifie si le billet spécial actuel est un billet Chessy Disney.
            if (_currentSpecialticket == rManager.GetString("_nameChessyDisneyticket").ToString())
            {
                // Boucle pour créer le nombre spécifié de billets Chessy Disney.
                for (int i = 0; i < numberTicket; i++)
                {
                    // Ajoute un nouveau billet à la liste des billets dans le modèle.
                    _model.Tickets.Add(new Ticket(price: (_model.PricesChessyDisneyticketOne) * reducedMultiply, name: _currentSpecialticket, created: date));
                }
            }

            // Vérifie si le billet spécial actuel est un billet pour l'aéroport.
            if (_currentSpecialticket == rManager.GetString("_nameAirporticket").ToString())
            {
                // Boucle pour créer le nombre spécifié de billets pour l'aéroport.
                for (int i = 0; i < numberTicket; i++)
                {
                    // Ajoute un nouveau billet à la liste des billets dans le modèle.
                    _model.Tickets.Add(new Ticket(price: (_model.PricesAirportyticketOne) * reducedMultiply, name: _currentSpecialticket, created: date));
                }
            }

            // Vérifie si le billet spécial actuel est un billet Paris Visite.
            if (_currentSpecialticket == rManager.GetString("_nameParisVisiteticket").ToString())
            {
                // Boucle pour créer le nombre spécifié de billets Paris Visite.
                for (int i = 0; i < numberTicket; i++)
                {
                    // Ajoute un nouveau billet à la liste des billets dans le modèle.
                    _model.Tickets.Add(new Ticket(price: (_model.PricesParisVisiteticketOne) * reducedMultiply, name: _currentSpecialticket, created: date));
                }
            }
        }

        /// <summary>
        /// Change la langue de l'application.
        /// </summary>
        /// <param name="lang">Nouvelle langue.</param>
        public void Lang(Language lang)
        {
            //recupre la langue
            _currentLanguage = lang;

            //
            switch (_currentLanguage)
            {
                //attribut la bonne langue.
                case Language.English:
                    rManager = new ResourceManager(typeof(Ressources.English));
                    break;
                case Language.French:
                    rManager = new ResourceManager(typeof(Ressources.French));
                    break;
                case Language.Spanish:
                    rManager = new ResourceManager(typeof(Ressources.Spanish));
                    break;
                case Language.Deutsh:
                    rManager = new ResourceManager(typeof(Ressources.Deutsh));
                    break;
                case Language.Italian:
                    rManager = new ResourceManager(typeof(Ressources.Italian));
                    break;
                default:
                    break;
            }

            // Met à jour la langue de toutes les vues.
            _view.UpdateLang(rManager);
            _viewBillorNot.UpdateLang(rManager);
            _viewMyallChoices.UpdateLang(rManager);
            _viewNormalticketChoices.UpdateLang(rManager);
            _viewSelectnavigoOrnot.UpdateLang(rManager);
            _viewSelectpaymentMethod.UpdateLang(rManager);
            _viewSelectspecialorNormaltickets.UpdateLang(rManager);
            _viewSelectspecialtickets.UpdateLang(rManager);
            _viewSpecialticketsChoices.UpdateLang(rManager);
        }

        /// <summary>
        /// Ajoute un nouveau billet à prix normal à la collection de billets dans le modèle.
        /// </summary>
        /// <param name="date">La date de création du billet.</param>
        /// <param name="numberTicket">Le nombre de billets à créer.</param>
        public void GetnewNormalticket(DateTime date, int numberTicket)
        {
            // Récupérer le nom du billet standard à partir du gestionnaire de ressources.
            _model.NameStandardticket = rManager.GetString("_nameStandardticket").ToString();

            // Ajouter un nouveau billet standard pour chaque nombre spécifié.
            for (int i = 0; i < numberTicket; i++)
            {
                // Créer un nouveau billet avec le prix standard, le nom et la date spécifiés,
                // puis l'ajouter à la liste des billets du modèle.
                _model.Tickets.Add(new Ticket(price: _model.PriceStandardTicket, name: _model.NameStandardticket, created: date));
            }
        }

        /// <summary>
        /// Ajoute un nouveau billet à prix réduit à la collection de billets dans le modèle.
        /// </summary>
        /// <param name="date">La date de création du billet.</param>
        /// <param name="numberTicket">Le nombre de billets à créer.</param>
        public void GetnewReducedticket(DateTime date, int numberTicket)
        {
            // Récupérer le nom du billet réduit à partir du gestionnaire de ressources.
            _model.NameReducedticket = rManager.GetString("_nameReducedticket").ToString();

            // Boucle pour ajouter le nombre spécifié de billets réduits.
            for (int i = 0; i < numberTicket; i++)
            {
                // Créer un nouveau billet avec le prix réduit, le nom et la date spécifiés,
                // puis l'ajouter à la liste des billets du modèle.
                _model.Tickets.Add(new Ticket(price: _model.PriceReducedticket, name: _model.NameReducedticket, created: date));
            }
        }

        /// <summary>
        /// Vérifie si les deux étiquettes de billets contiennent des valeurs zéro.
        /// </summary>
        /// <param name="numberTicketnormalPrice">Le nombre de billets au prix normal.</param>
        /// <param name="numberTicketreducedprice">Le nombre de billets à prix réduit.</param>
        /// <returns>Retourne true si les deux valeurs sont zéro, sinon false.</returns>
        public bool ChecktwoLabelcontainZeroTicket(int numberTicketnormalPrice, int numberTicketreducedprice)
        {
            // Initialiser une variable booléenne pour indiquer si les deux étiquettes contiennent zéro.
            bool isRight = false;

            // Vérifier si les deux valeurs sont zéro.
            if (numberTicketreducedprice == 0 && numberTicketnormalPrice == 0)
            {
                // Si les deux valeurs sont zéro et définir isRight à true.
                isRight = true;
            }
            else
            {
                // Sinon, définir isRight à false.
                isRight = false;
            }

            // Retourner le résultat de la vérification.
            return isRight;
        }

        /// <summary>
        /// Incrémente le nombre de billets à prix normal.
        /// </summary>
        /// <param name="infoNumbernormalTicket">Le nombre actuel de billets à prix normal en tant que chaîne de caractères.</param>
        /// <returns>Le nouveau nombre de billets à prix normal en tant que chaîne de caractères.</returns>
        public string UpCountNormalprice(string infoNumbernormalTicket)
        {
            // Convertir la chaîne en entier pour pouvoir incrémenter.
            _countNormalpriceTicket = Convert.ToInt32(infoNumbernormalTicket);

            // Incrément le nombre de billets
            _countNormalpriceTicket++;

            // Convertir l'entier mis à jour en chaîne de caractères.
            infoNumbernormalTicket = Convert.ToString(_countNormalpriceTicket);

            // Retourner le nouveau nombre de billets sous forme de chaîne.
            return infoNumbernormalTicket;
        }

        /// <summary>
        /// Décrémente le nombre de billets à prix normal.
        /// </summary>
        /// <param name="infoNumbernormalTicket">Le nombre actuel de billets à prix normal en tant que chaîne de caractères.</param>
        /// <returns>Le nouveau nombre de billets à prix normal en tant que chaîne de caractères.</returns>
        public string DownCountNormalprice(string infoNumbernormalTicket)
        {

            // Convertir la chaîne en entier pour pouvoir décrémenter
            _countNormalpriceTicket = Convert.ToInt32(infoNumbernormalTicket);

            // Décrémenter le nombre de billets.
            _countNormalpriceTicket--;

            // S'assurer que le nombre de billets ne descend pas en dessous de zéro.
            if (_countNormalpriceTicket < 0)
            {
                _countNormalpriceTicket = 0;
            }

            // Convertir l'entier mis à jour en chaîne de caractères.
            infoNumbernormalTicket = Convert.ToString(_countNormalpriceTicket);

            // Retourner le nouveau nombre de billets sous forme de chaîne.
            return infoNumbernormalTicket;
        }

        /// <summary>
        /// Incrémente le nombre de billets à prix réduit.
        /// </summary>
        /// <param name="infoNumberreducedTicket">Le nombre actuel de billets à prix réduit en tant que chaîne de caractères.</param>
        /// <returns>Le nouveau nombre de billets à prix réduit en tant que chaîne de caractères.</returns>
        public string UpCountReducedprice(string infoNumberreducedTicket)
        {
            // Convertir la chaîne en entier pour pouvoir décrémenter
            _countReducedpriceTicket = Convert.ToInt32(infoNumberreducedTicket);

            // Incrémenter le nombre de billets.
            _countReducedpriceTicket++;

            // Convertir l'entier mis à jour en chaîne de caractères.
            infoNumberreducedTicket = Convert.ToString(_countReducedpriceTicket);

            // Retourner le nouveau nombre de billets sous forme de chaîne.
            return infoNumberreducedTicket;
        }

        /// <summary>
        /// Décrémente le nombre de billets à prix réduit.
        /// </summary>
        /// <param name="infoNumberreducedTicket">Le nombre actuel de billets à prix réduit en tant que chaîne de caractères.</param>
        /// <returns>Le nouveau nombre de billets à prix réduit en tant que chaîne de caractères.</returns>
        public string DowmCountReducedprice(string infoNumberreducedTicket)
        {

            //// Convertir la chaîne en entier pour pouvoir décrémenter
            _countReducedpriceTicket = Convert.ToInt32(infoNumberreducedTicket);

            // Décrémenter le nombre de billets.
            _countReducedpriceTicket--;

            // S'assurer que le nombre de billets ne descend pas en dessous de zéro.
            if (_countReducedpriceTicket < 0)
            {
                // Met le compteur à 0.
                _countReducedpriceTicket = 0;

            }

            // Convertir l'entier mis à jour en chaîne de caractères.
            infoNumberreducedTicket = Convert.ToString(_countReducedpriceTicket);

            // Retourner le nouveau nombre de billets sous forme de chaîne.
            return infoNumberreducedTicket;
        }

        /// <summary>
        /// Affiche les informations des billets sur le panneau spécifié.
        /// </summary>
        /// <param name="panel">Le panneau où les informations des billets seront affichées.</param>
        public void DisplayTickets(Panel panel)
        {

            // Regroupe les billets à prix réduit en fonction de leur nom, obtenu à partir du gestionnaire de ressources.
            var discountedTickets = _model.Tickets
                .Where(t => t.Name == (rManager.GetString("_nameReducedticket")).ToString())
                .ToList();

            // Compte le nombre de billets à prix réduit.
            int discountedCount = discountedTickets.Count;
            // Calcule le prix total des billets à prix réduit.
            double discountedTotalPrice = discountedTickets.Sum(t => t.Price);

            // Regroupe les billets standard en fonction de leur nom, obtenu à partir du gestionnaire de ressources.
            var standardTickets = _model.Tickets
                .Where(t => t.Name == (rManager.GetString("_nameStandardticket")).ToString())
                .ToList();

            // Compte le nombre de billets standard.
            int standardCount = standardTickets.Count;
            // Calcule le prix total des billets standard.
            double standardTotalPrice = standardTickets.Sum(t => t.Price);

            // Regroupe les billets Chessy Disney en fonction de leur nom, obtenu à partir du gestionnaire de ressources.
            var disneyChessytikets = _model.Tickets
                .Where(t => t.Name == (rManager.GetString("_nameChessyDisneyticket")).ToString())
                .ToList();

            // Compte le nombre de billets Chessy Disney.
            int disneyChessycount = disneyChessytikets.Count;
            // Calcule le prix total des billets Chessy Disney.
            double disneyChessyTotalPrice = disneyChessytikets.Sum(t => t.Price);

            // Regroupe les billets pour l'aéroport en fonction de leur nom, obtenu à partir du gestionnaire de ressources.
            var airportTickets = _model.Tickets
                .Where(t => t.Name == (rManager.GetString("_nameAirporticket")).ToString())
                .ToList();

            // Compte le nombre de billets pour l'aéroport.
            int airportCount = airportTickets.Count;
            // Calcule le prix total des billets pour l'aéroport.
            double airportTotalPrice = airportTickets.Sum(t => t.Price);

            // Regroupe les billets Paris Visite en fonction de leur nom, obtenu à partir du gestionnaire de ressources.
            var parisVisitetikets = _model.Tickets
                .Where(t => t.Name == (rManager.GetString("_nameParisVisiteticket")).ToString())
                .ToList();

            // Compte le nombre de billets Paris Visite.
            int parisVisitecount = parisVisitetikets.Count;
            // Calcule le prix total des billets Paris Visite.
            double parisVisitetotalprice = parisVisitetikets.Sum(t => t.Price);

            // Calcule le nombre total de billets.
            int totalTickets = discountedCount + standardCount + disneyChessycount + airportCount + parisVisitecount;
            // Calcule le prix total de tous les billets.
            double totalPrice = discountedTotalPrice + standardTotalPrice + disneyChessyTotalPrice + airportTotalPrice + parisVisitetotalprice;

            // Crée et positionne les étiquettes (labels) pour afficher les noms des types de billets.
            AddLabelToPanel(panel, rManager.GetString("_nameReducedticket").ToString(), 0);
            AddLabelToPanel(panel, rManager.GetString("_nameStandardticket").ToString(), 1);
            AddLabelToPanel(panel, rManager.GetString("_nameChessyDisneyticket").ToString(), 2);
            AddLabelToPanel(panel, rManager.GetString("_nameAirporticket").ToString(), 3);
            AddLabelToPanel(panel, rManager.GetString("_nameParisVisiteticket").ToString(), 4);
            AddLabelToPanel(panel, "Total des tickets :", 5);
            

            // Crée et positionne les étiquettes pour afficher le nombre de chaque type de billet.
            AddLabelCountToPanel(panel, totalTickets, 5);
            AddLabelCountToPanel(panel, discountedCount, 4);
            AddLabelCountToPanel(panel, standardCount, 1);
            AddLabelCountToPanel(panel, disneyChessycount, 2);
            AddLabelCountToPanel(panel, airportCount, 3);
            AddLabelCountToPanel(panel, parisVisitecount, 0);



            // Crée et positionne les étiquettes pour afficher le prix total de chaque type de billet.
            AddLabelPriceToPanel(panel, totalPrice, 5);
            AddLabelPriceToPanel(panel, discountedTotalPrice, 4);
            AddLabelPriceToPanel(panel, standardTotalPrice, 1);
            AddLabelPriceToPanel(panel, disneyChessyTotalPrice, 2);
            AddLabelPriceToPanel(panel, airportTotalPrice, 3);
            AddLabelPriceToPanel(panel, parisVisitetotalprice, 0);
            
        }

        /// <summary>
        /// Ajoute une étiquette de texte (label) à un panneau à la position spécifiée.
        /// </summary>
        /// <param name="panel">Le panneau où l'étiquette sera ajoutée.</param>
        /// <param name="labelText">Le texte à afficher dans l'étiquette.</param>
        /// <param name="rowIndex">L'index de la ligne où l'étiquette sera positionnée.</param>
        private static void AddLabelToPanel(Panel panel, string labelText, int rowIndex)
        {
            // Définir la largeur et la hauteur de l'étiquette.
            int labelWidth = 150;
            int labelHeight = 20;
            // Espacement vertical entre les étiquettes.
            int labelSpacing = 30;

            // Créer l'étiquette pour le texte avec les propriétés spécifiées.
            Label lblText = new Label
            {
                Text = labelText, // Texte de l'étiquette.
                Location = new System.Drawing.Point(10, rowIndex * labelSpacing), // Position de l'étiquette.
                Size = new System.Drawing.Size(labelWidth, labelHeight) // Taille de l'étiquette.
            };

            // Ajouter l'étiquette au panneau.
            panel.Controls.Add(lblText);
        }

        /// <summary>
        /// Ajoute une étiquette pour afficher un compte (nombre) à un panneau à la position spécifiée.
        /// </summary>
        /// <param name="panel">Le panneau où l'étiquette sera ajoutée.</param>
        /// <param name="count">Le nombre à afficher dans l'étiquette.</param>
        /// <param name="rowIndex">L'index de la ligne où l'étiquette sera positionnée.</param>
        private static void AddLabelCountToPanel(Panel panel, double count, int rowIndex)
        {
            // Définir la largeur et la hauteur de l'étiquette.
            int labelWidth = 150;
            int labelHeight = 20;
            // Espacement vertical entre les étiquettes.
            int labelSpacing = 30;

            // Créer l'étiquette pour le compte avec les propriétés spécifiées.
            Label lblCount = new Label
            {
                Text = count.ToString(), // Convertir le nombre en chaîne de caractères.
                Location = new System.Drawing.Point(170, rowIndex * labelSpacing), // Position de l'étiquette.
                Size = new System.Drawing.Size(labelWidth, labelHeight) // Taille de l'étiquette.
            };

            // Ajouter l'étiquette au panneau.
            panel.Controls.Add(lblCount);
        }

        /// <summary>
        /// Ajoute une étiquette pour afficher un prix à un panneau à la position spécifiée.
        /// </summary>
        /// <param name="panel">Le panneau où l'étiquette sera ajoutée.</param>
        /// <param name="count">Le prix à afficher dans l'étiquette.</param>
        /// <param name="rowIndex">L'index de la ligne où l'étiquette sera positionnée.</param>
        private static void AddLabelPriceToPanel(Panel panel, double count, int rowIndex)
        {
            // Définir la largeur et la hauteur de l'étiquette.
            int labelWidth = 150;
            int labelHeight = 20;
            // Espacement vertical entre les étiquettes.
            int labelSpacing = 30;

            // Créer l'étiquette pour le prix avec les propriétés spécifiées.
            Label lblPrice = new Label
            {
                Text = count.ToString(), // Convertir le prix en chaîne de caractères. Ici, on pourrait formater en tant que devise si nécessaire.
                Location = new System.Drawing.Point(330, rowIndex * labelSpacing), // Position de l'étiquette.
                Size = new System.Drawing.Size(labelWidth, labelHeight) // Taille de l'étiquette.
            };

            // Ajouter l'étiquette au panneau.
            panel.Controls.Add(lblPrice);
        }

        /// <summary>
        /// Méthode pour appeler le texte de controle de champs nombre de tickets
        /// </summary>
        public void ShowmessageZeroTicket()
        {
            //Affiche du message
            MessageBox.Show(rManager.GetString("zeroTicketselected"));
        }


        /// <summary>
        /// 
        /// </summary>
        public void ShowvalidTicketmessage()
        {
            //
            MessageBox.Show(rManager.GetString("validTicketselected"));
        }


        /// <summary>
        /// 
        /// </summary>
        public void GetlabelHeardertextChessydisneyTicket()
        {
            _currentSpecialticket = rManager.GetString("_nameChessyDisneyticket").ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetlabelHeardertextAirportticket()
        {
            _currentSpecialticket = rManager.GetString("_nameAirporticket").ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetlabelHeardertextParisvisiteTicket()
        {
            _currentSpecialticket = rManager.GetString("_nameParisVisiteticket").ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public void MessagetoPay()
        {
            //
            MessageBox.Show(rManager.GetString("pleasePay"));
        }
    }
}
