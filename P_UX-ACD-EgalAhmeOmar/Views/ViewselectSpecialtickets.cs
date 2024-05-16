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
    public partial class ViewselectSpecialtickets : Form
    {
        public ViewselectSpecialtickets()
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
            Controller.ShowViewselectSpecialorNormalticketstoViewselectSpecialticket();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChessydisneyTicket_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewSpecialticketChoices();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParisvisite_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewSpecialticketChoices();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAirportticket_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewSpecialticketChoices();
        }
    }
}
