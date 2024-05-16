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
    public partial class ViewselectSpecialorNormaltickets : Form
    {
        public ViewselectSpecialorNormaltickets()
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
            Controller.ShowViewselectNavigoorNottoViewselectSpecialorNormaltickets();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBasicTickets_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewnormalTicketChoices();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpecialtickets_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewselectSpecialtickets();
        }
    }
}
