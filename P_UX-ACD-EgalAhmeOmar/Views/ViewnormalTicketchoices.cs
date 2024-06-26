﻿///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans une des vues.
///**************************************************************************************
using System;
using System.Resources;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar.Views
{
    public partial class ViewnormalTicketchoices : Form
    {
        public ViewnormalTicketchoices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contrôleur associé à cette vue.
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton de retour dans l'en-tête.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnBackinHeader_Click(object sender, EventArgs e)
        {
            // Affiche la vue pour choisir entre les différents types de tickets normaux.
            Controller.ShowViewselectSpecialorNormalticketstoViewnormalTicketChoices();
        }

        /// <summary>
        /// Met à jour la langue de l'interface utilisateur en utilisant un ResourceManager.
        /// </summary>
        /// <param name="_resourcesManager">ResourceManager pour les ressources de localisation.</param>
        public void UpdateLang(ResourceManager _resourcesManager)
        {
            ResourceManager resourceManager = _resourcesManager; // Initialise le gestionnaire de ressources.

            foreach (Control c in this.Controls) // Parcourt tous les contrôles dans cette vue.
            {
                UpdateLevel(c); // Appelle la méthode pour mettre à jour les contrôles enfants.
            }

            // Traduction récursive dans les contrôles enfants
            void UpdateLevel(Control parentControl)
            {
                if (parentControl.HasChildren) // Si le contrôle a des enfants.
                {
                    foreach (Control childControl in parentControl.Controls) // Parcourt tous les enfants du contrôle.
                    {
                        UpdateLevel(childControl); // Appelle récursivement la méthode pour mettre à jour chaque enfant.
                    }
                }
                if (resourceManager.GetString(parentControl.Name) != null) // Vérifie si le nom du contrôle est une clé de ressource.
                {
                    parentControl.Text = resourceManager.GetString(parentControl.Name); // Met à jour le texte du contrôle avec la valeur de la ressource correspondante.
                }
            }
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton de validation des informations.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        public void btnValidatorInfos_Click(object sender, EventArgs e)
        {
            // Vérifie si les deux étiquettes contiennent un nombre de tickets non nul.
            if (Controller.ChecktwoLabelcontainZeroTicket(Convert.ToInt32(lblNumberstandardTickets.Text),
                Convert.ToInt32(lblNumberreducedTickets.Text)) is false)
            {
                // Appel de la méthode dans le contrôleur pour ajouter des tickets normaux avec la date et la quantité spécifiées.
                Controller.GetnewNormalticket(dateTimePickerNormalTicket.Value, Convert.ToInt32(lblNumberstandardTickets.Text));

                // Appel de la méthode dans le contrôleur pour ajouter des tickets réduits avec la date et la quantité spécifiées.
                Controller.GetnewReducedticket(dateTimePickerNormalTicket.Value, Convert.ToInt32(lblNumberreducedTickets.Text));

                // Affiche un message de validation des tickets.
                Controller.ShowvalidTicketmessage();

                // Affiche la vue pour choisir entre les différents types de tickets normaux.
                Controller.ShowViewallMychoicestoViewnormalTicketChoices();
            }
            else
            {
                // Affiche un message indiquant qu'au moins un des types de tickets est nul.
                Controller.ShowmessageZeroTicket();
            }
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Augmenter" pour le prix standard.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnUpstandardPrice_Click(object sender, EventArgs e)
        {
            // Augmente le nombre de tickets standard et met à jour l'affichage.
            lblNumberstandardTickets.Text = Controller.UpCountNormalprice(lblNumberstandardTickets.Text);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Diminuer" pour le prix standard.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnDownstandardPrice_Click(object sender, EventArgs e)
        {
            // Diminue le nombre de tickets standard et met à jour l'affichage.
            lblNumberstandardTickets.Text = Controller.DownCountNormalprice(lblNumberstandardTickets.Text);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Augmenter" pour le prix réduit.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnUpreducedPrice_Click(object sender, EventArgs e)
        {
            // Augmente le nombre de tickets réduits et met à jour l'affichage.
            lblNumberreducedTickets.Text = Controller.UpCountReducedprice(lblNumberreducedTickets.Text);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Diminuer" pour le prix réduit.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnDownreducedPrice_Click(object sender, EventArgs e)
        {
            // Diminue le nombre de tickets réduits et met à jour l'affichage.
            lblNumberreducedTickets.Text = Controller.DowmCountReducedprice(lblNumberreducedTickets.Text);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Français" dans le pied de page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnFrenchinFooter_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur le français.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.French);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Anglais" dans le pied de page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnEnglishinFooter_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'anglais.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.English);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Espagnol" dans le pied de page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnSpanishinFooter_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'espagnol.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Spanish);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Allemand" dans le pied de page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnDeutshinFooter_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'allemand.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Deutsh);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Italien" dans le pied de page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnItalianinFooter_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'italien.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Italian);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Arrêt" dans le pied de page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnStopInFooter_Click(object sender, EventArgs e)
        {
            // Affiche la vue avec le bouton "Arrêt".
            Controller.ShowviewWithbtnStop(FindForm());
        }

        /// <summary>
        /// Événement déclenché lors de l'activation de la vue
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void ViewnormalTicketchoices_Activated(object sender, EventArgs e)
        {
            //Affiche le total des prix dans le pnlCurrentPurshase
            Controller.SetcurrentTotalpriceinPanel(pnlCurrentpurchase);
        }
    }
}
