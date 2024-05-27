using P_UX_ACD_EgalAhmeOmar.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            UpdateControlText(this, resources);
        }

        /// <summary>
        /// Parcourt tous les contrôles de la vue et met à jour leur texte selon la langue sélectionnée.
        /// </summary>
        /// <param name="parentControl">Le contrôle parent dont les sous-contrôles doivent être mis à jour.</param>
        /// <param name="resources">Le ResourceManager contenant les ressources de localisation.</param>
        private void UpdateControlText(Control parentControl, ResourceManager resources)
        {
            foreach (Control c in parentControl.Controls)
            {
                if (!string.IsNullOrEmpty(c.Name))
                {
                    string resourceValue = resources.GetString(c.Name);
                    if (resourceValue != null)
                    {
                        Debug.Assert(resourceValue != null, $"Updating {c.Name} to {resourceValue}");
                        c.Text = resourceValue;
                    }
                    else
                    {
                        Debug.Assert(condition: resourceValue == null, $"No resource found for {c.Name}");
                    }
                }

                if (c.HasChildren)
                {
                    UpdateControlText(c, resources);
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
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.English);
               
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
