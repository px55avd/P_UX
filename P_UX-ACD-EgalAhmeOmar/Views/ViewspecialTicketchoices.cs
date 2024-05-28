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
    public partial class ViewspecialTicketchoices : Form
    {
        public ViewspecialTicketchoices()
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
            lbltextinHeader.Text = Controller.SetnullSpecialticket();

            //
            Controller.ShowViewselectSpecialtickettoViewspecialTicketChoices();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorInfos_Click(object sender, EventArgs e)
        {
            //
            Controller.GetnumberofSpecialTicket(radioBtnoneSpecialticket.Checked, radioBtnthreeSpecialticket.Checked, 
                radioBtnfiveSpecialticket.Checked, radioBtnStandardprice.Checked, radioBtnreducedPrice.Checked, dateTimepickerSelected.Value);

            //
            Controller.ShowvalidTicketmessage();

            //
            Controller.ShowViewallMychoicestoViewspecialTicketChoices();
            
        }


        private void ViewspecialTicketchoices_Shown(object sender, EventArgs e)
        {
            //
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }

        private void ViewspecialTicketchoices_Load(object sender, EventArgs e)
        {
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }

        private void ViewspecialTicketchoices_Activated(object sender, EventArgs e)
        {
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }
    }
}
