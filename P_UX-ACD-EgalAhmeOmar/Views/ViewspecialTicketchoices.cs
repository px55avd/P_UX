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
            ResourceManager resourceManager = _resourcesManager;


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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewspecialTicketchoices_Shown(object sender, EventArgs e)
        {
            //
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewspecialTicketchoices_Load(object sender, EventArgs e)
        {
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewspecialTicketchoices_Activated(object sender, EventArgs e)
        {
            lbltextinHeader.Text = Controller.SetcurrentSpecialticket();
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
