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
        /// Iterate through every Controls in the view recursivly and update language with ressource 
        /// </summary>
        /// <param name="resourceManager">Ressource manager for target language</param>
        public void UpdateLang(ResourceManager _resourceManager)
        {

            ResourceManager resourceManager = _resourceManager;

            foreach (Control c in this.Controls)
            {
                UpdateLevel(c);
            }

            // Recursivly translate in child control
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
