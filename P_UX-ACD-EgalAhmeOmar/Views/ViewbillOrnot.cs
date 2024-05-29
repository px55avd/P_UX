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
    public partial class ViewbillOrnot : Form
    {
        public ViewbillOrnot()
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

            foreach (Control c in this.Controls)
            {
                UpdateLevel(c);
            }

            // Traduit récursivement dans les contrôles enfants
            void UpdateLevel(Control parentControl)
            {
                if (parentControl.HasChildren)
                {
                    foreach (Control childControl in parentControl.Controls)
                    {
                        UpdateLevel(childControl);
                    }
                }
                if (resourceManager.GetString(parentControl.Name) != null)
                {
                    parentControl.Text = resourceManager.GetString(parentControl.Name);
                }
            }
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton "Oui" pour le reçu.
        /// </summary>
        private void btnYesforReceipt_Click(object sender, EventArgs e)
        {
            // Afficher la vue associée à la décision concernant le reçu.
            Controller.ShowViewtoViewbillOrnot();
        }

        /// <summary>
        /// Action exécutée lors du clic sur le bouton "Non" pour le reçu.
        /// </summary>
        private void btnNoforReceipt_Click(object sender, EventArgs e)
        {
            // Afficher la vue associée à la décision concernant le reçu.
            Controller.ShowViewtoViewbillOrnot();
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
