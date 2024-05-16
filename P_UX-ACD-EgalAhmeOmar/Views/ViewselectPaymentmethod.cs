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
    public partial class ViewselectPaymentmethod : Form
    {
        public ViewselectPaymentmethod()
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
            Controller.ShowViewallMyChoicestoViewselectPaymentmethod();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorgooglePay_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewbillOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorcard_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewbillOrnot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatorcoinsAndnotes_Click(object sender, EventArgs e)
        {
            //
            Controller.ShowViewbillOrnot();
        }
    }
}
