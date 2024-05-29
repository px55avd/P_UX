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
    public partial class ViewselectPaymentmethod : Form
    {
        public ViewselectPaymentmethod()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// Met à jour la langue de l'interface utilisateur en utilisant un ResourceManager.
        /// </summary>
        /// <param name="_resourcesManager">ResourceManager pour les ressources de localisation.</param>
        public void UpdateLang(ResourceManager _resourcesManager)
        {
            ResourceManager resources = _resourcesManager;

            // Parcourt tous les contrôles de la vue et met à jour leur texte selon la langue sélectionnée.
            foreach (Control c in Controls)
            {
                if (resources.GetString(c.Name) != null)
                {
                    c.Text = resources.GetString(c.Name);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackinHeader_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewallMyChoicestoViewselectPaymentmethod();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorgooglePay_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewbillOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorcard_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewbillOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorcoinsAndnotes_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewbillOrnot();
        }

        private void btnFrenchinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.French);
        }

        private void btnEnglishinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.English);
        }

        private void btnSpanishinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Spanish);
        }

        private void btnDeutshinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Deutsh);
        }

        private void btnItalianinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Italian);
        }

        private void btnStopInFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowviewWithbtnStop(FindForm());
        }
    }
}
