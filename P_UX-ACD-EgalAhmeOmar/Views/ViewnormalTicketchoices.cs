using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorInfos_Click(object sender, EventArgs e)
        {

            //
            if (Controller.ChecktwoLabelcontainZeroTicket(Convert.ToInt32(lblNumberstandardTickets.Text), Convert.ToInt32(lblNumberreducedTickets.Text)) is false)
            {

                //Applle de la méthode dans le controleur
                Controller.GetnewTicket(lblStandardprice.Text, dateTimePickerNormalTicket.Value, Convert.ToInt32(lblNumberstandardTickets.Text));

                //Applle de la méthode dans le controleur
                Controller.GetnewTicket(lblReducedprice.Text, dateTimePickerNormalTicket.Value, Convert.ToInt32(lblNumberreducedTickets.Text));

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
