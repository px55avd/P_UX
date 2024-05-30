///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans une des vues.
///**************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar.Views
{
    public partial class ViewmyAllchoices : Form
    {
        public ViewmyAllchoices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contrôleur associé à cette vue.
        /// </summary>
        public Controller.Controller Controller { get; set; }


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
        /// Action exécutée lors du clic sur le bouton "Retour" dans l'en-tête.
        /// </summary>
        private void btnBackinHeader_Click(object sender, EventArgs e)
        {
            // Afficher la vue des choix spéciaux ou normaux.
            Controller.ShowSpecialorNormalticketChoicestoViewallmyChoices();
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton "Suivant" pour l'achat.
        /// </summary>
        private void btnNextpurchase_Click(object sender, EventArgs e)
        {
            // Afficher la vue de sélection du type de billet (spécial ou normal).
            Controller.ShowViewselectSpecialorNormaltickettoViewallMychoices();
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton "Payer".
        /// </summary>
        private void btnPay_Click(object sender, EventArgs e)
        {
            // Afficher la vue de sélection du mode de paiement.
            Controller.ShowViewselectPaymentMethod();
        }

        /// <summary>
        /// Action exécutée lors de l'activation de cette vue.
        /// </summary>
        private void ViewmyAllchoices_Activated(object sender, EventArgs e)
        {
            // Afficher les billets dans le panneau d'informations.
            Controller.DisplayTickets(pnlInfos);
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
    }
}
