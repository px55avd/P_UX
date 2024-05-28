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
    public partial class ViewselectNavigoorNot : Form
    {
        public ViewselectNavigoorNot()
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewtoViewselectNavigoOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDonthaveNavigo_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectSpecialorNormaltickets();
        }
    }
}
