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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpstandardPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberstandardTickets.Text = Controller.UpCountNormalprice(lblNumberstandardTickets.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownstandardPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberstandardTickets.Text = Controller.DownCountNormalprice( lblNumberstandardTickets.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpreducedPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberreducedTickets.Text = Controller.UpCountReducedprice(lblNumberreducedTickets.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownreducedPrice_Click(object sender, EventArgs e)
        {
            //
            lblNumberreducedTickets.Text = Controller.DowmCountReducedprice(lblNumberreducedTickets.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrenchinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.French);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnglishinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.English);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpanishinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Spanish);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeutshinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Deutsh);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItalianinFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Italian);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopInFooter_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowviewWithbtnStop(FindForm());
        }
    }
}
