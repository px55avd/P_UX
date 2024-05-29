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
    // Cette classe représente une fenêtre (Form) spécifique dans l'application.
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
        /// Parcourt récursivement tous les contrôles dans la vue et met à jour la langue avec les ressources fournies.
        /// </summary>
        /// <param name="resourceManager">Gestionnaire de ressources pour la langue cible.</param>
        public void UpdateLang(ResourceManager _resourceManager)
        {
            ResourceManager resourceManager = _resourceManager;

            // Parcourir tous les contrôles dans cette vue
            foreach (Control c in this.Controls)
            {
                UpdateLevel(c);
            }

            // Traduire récursivement dans les contrôles enfants
            void UpdateLevel(Control parentControl)
            {
                if (parentControl.HasChildren)
                {
                    foreach (Control childControl in parentControl.Controls)
                    {
                        UpdateLevel(childControl);
                    }
                }
                // Mettre à jour le texte du contrôle s'il existe une clé de ressource correspondante
                if (resourceManager.GetString(parentControl.Name) != null)
                {
                    parentControl.Text = resourceManager.GetString(parentControl.Name);
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
        /// Action exécutée lors du clic sur le bouton pour le français dans le pied de page.
        /// </summary>
        private void btnFrenchinFooter_Click(object sender, EventArgs e)
        {
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.French);
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton pour l'anglais dans le pied de page.
        /// </summary>
        private void btnEnglishinFooter_Click(object sender, EventArgs e)
        {
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.English);
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton pour l'espagnol dans le pied de page.
        /// </summary>
        private void btnSpanishinFooter_Click(object sender, EventArgs e)
        {
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Spanish);
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton pour l'allemand dans le pied de page.
        /// </summary>
        private void btnDeutshinFooter_Click(object sender, EventArgs e)
        {
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Deutsh);
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton pour l'italien dans le pied de page.
        /// </summary>
        private void btnItalianinFooter_Click(object sender, EventArgs e)
        {
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Italian);
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton "Arrêter" dans le pied de page.
        /// </summary>
        private void btnStopInFooter_Click(object sender, EventArgs e)
        {
            // Afficher la vue associée au bouton "Arrêter".
            Controller.ShowviewWithbtnStop(FindForm());
        }
    }
}
