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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackinHeader_Click(object sender, EventArgs e)
        {
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
            Controller.ShowViewallMychoicestoViewspecialTicketChoices();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParisvisiteOneday_Click(object sender, EventArgs e)
        {
            //
            Controller.GetnumberofSpecialTicket(btnParisvisiteOneday.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParisvisiteThreeday_Click(object sender, EventArgs e)
        {
            //
            Controller.GetnumberofSpecialTicket(btnParisvisiteThreeday.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParisvisiteFiveday_Click(object sender, EventArgs e)
        {
            //
            Controller.GetnumberofSpecialTicket(btnParisvisiteFiveday.Text);

        }
    }
}
