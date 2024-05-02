using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P_UX_ACD_EgalAhmeOmar.Controller
{
    public class Controller
    {
        private View _view;
        private Model.Model _model;

        public Controller(View view, Model.Model model)
        {
            _view = view;
            _model = model;
            _model.Controller = this;
            _view.Controller = this;
        }
    }
}
