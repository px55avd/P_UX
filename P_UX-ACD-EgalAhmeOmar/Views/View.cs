using P_UX_ACD_EgalAhmeOmar.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }
    }
}
