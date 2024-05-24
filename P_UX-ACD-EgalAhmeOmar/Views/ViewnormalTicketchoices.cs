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
    public partial class ViewnormalTicketchoices : Form
    {
        public ViewnormalTicketchoices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackinHeader_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectSpecialorNormalticketstoViewnormalTicketChoices();
        }

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
        public void btnValidatorInfos_Click(object sender, EventArgs e)
        {

            //
            if (Controller.ChecktwoLabelcontainZeroTicket(Convert.ToInt32(lblNumberstandardTickets.Text), 
                Convert.ToInt32(lblNumberreducedTickets.Text)) is false)
            {

                //Applle de la méthode dans le controleur
                Controller.GetnewNormalticket(dateTimePickerNormalTicket.Value, 
                    Convert.ToInt32(lblNumberstandardTickets.Text));

                //Applle de la méthode dans le controleur
                Controller.GetnewReducedticket(dateTimePickerNormalTicket.Value, 
                    Convert.ToInt32(lblNumberreducedTickets.Text));

                //
                Controller.ShowvalidTicketmessage();

                //Applle de la méthode dans le controleur
                Controller.ShowViewallMychoicestoViewnormalTicketChoices();

                
            }
            else
            {
                //
                Controller.ShowmessageZeroTicket();
            }
        }

        private void btnUpstandardPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberstandardTickets.Text = Controller.UpCountNormalprice(lblNumberstandardTickets.Text);
        }

        private void btnDownstandardPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberstandardTickets.Text = Controller.DownCountNormalprice( lblNumberstandardTickets.Text);
        }

        private void btnUpreducedPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberreducedTickets.Text = Controller.UpCountReducedprice(lblNumberstandardTickets.Text);
        }

        private void btnDownreducedPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberreducedTickets.Text = Controller.DowmCountReducedprice(lblNumberreducedTickets.Text);
        }
    }
}
