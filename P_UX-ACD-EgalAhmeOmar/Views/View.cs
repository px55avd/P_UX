using P_UX_ACD_EgalAhmeOmar.Controller;
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

namespace P_UX_ACD_EgalAhmeOmar
{
    public partial class View : Form
    {
        public View()
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
        private void btnEnglishinFirstpage_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeutshinFirstpage_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpanishinFirstpage_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItalianinFirstpage_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectNavigoOrnot();
        }
    }
}
