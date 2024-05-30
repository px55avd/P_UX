///**************************************************************************************
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
    public partial class ViewspecialTicketchoices : Form
    {
        public ViewspecialTicketchoices()
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
        /// Gère l'événement de clic sur le bouton de retour dans l'en-tête.
        /// </summary>
        /// <param name="sender">L'objet à l'origine de l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void btnBackinHeader_Click(object sender, EventArgs e)
        {
            // Efface le ticket spécial actuel.
            lbltextinHeader.Text = Controller.SetnullSpecialticket();

            // Affiche la vue de choix de ticket spécial.
            Controller.ShowViewselectSpecialtickettoViewspecialTicketChoices();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de validation d'informations.
        /// </summary>
        /// <param name="sender">L'objet à l'origine de l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void btnValidatorInfos_Click(object sender, EventArgs e)
        {
            // Appel de la méthode pour vérifier si les radio boutons sont vides.
            if (Controller.CheckradioBtncontainZeroTicket(radioBtnoneSpecialticket.Checked, radioBtnthreeSpecialticket.Checked,
                radioBtnfiveSpecialticket.Checked, radioBtnStandardprice.Checked, radioBtnreducedPrice.Checked) is false)
            {
                // Récupère le nombre de tickets spéciaux sélectionnés et enregistre les informations.
                Controller.GetnumberofSpecialTicket(radioBtnoneSpecialticket.Checked, radioBtnthreeSpecialticket.Checked,
                    radioBtnfiveSpecialticket.Checked, radioBtnStandardprice.Checked, radioBtnreducedPrice.Checked, dateTimepickerSelected.Value);

                // Affiche un message de validation pour les tickets.
                Controller.ShowvalidTicketmessage();

                // Affiche toutes les options de choix de tickets spéciaux.
                Controller.ShowViewallMychoicestoViewspecialTicketChoices();
            }
            else
            {
                // Affiche un message indiquant qu'au moins un des types de tickets est nul.
                Controller.ShowmessageZeroTicket();
            }
        }

        /// <summary>
        /// Événement déclenché lorsque la vue spécial Ticket est affichée.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void ViewspecialTicketchoices_Shown(object sender, EventArgs e)
        {
            // Met à jour le texte dans l'en-tête avec le ticket spécial actuel.
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }

        /// <summary>
        /// Événement déclenché lorsque la vue spécial Ticket est chargée.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void ViewspecialTicketchoices_Load(object sender, EventArgs e)
        {
            // Initialise le texte dans l'en-tête avec le ticket spécial actuel.
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }

        /// <summary>
        /// Événement déclenché lorsque la vue spécial Ticket est activée.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void ViewspecialTicketchoices_Activated(object sender, EventArgs e)
        {
            // Met à jour le texte dans l'en-tête avec le ticket spécial actuel.
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
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

            //Affiche le total des prix dans le pnlCurrentPurshase
            Controller.SetcurrentTotalpriceinPanel(pnlCurrentpurchase);
        }
    }
}
