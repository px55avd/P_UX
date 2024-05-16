using P_UX_ACD_EgalAhmeOmar.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar.Controller
{
    public class Controller
    {
        //
        private View _view;
        private ViewbillOrnot _viewBillorNot;
        private ViewmyAllchoices _viewMyallChoices;
        private ViewnormalTicketchoices _viewNormalticketChoices;
        private ViewselectNavigoorNot _viewSelectnavigoOrnot;
        private ViewselectPaymentmethod _viewSelectpaymentMethod;
        private ViewselectSpecialorNormaltickets _viewSelectspecialorNormaltickets;
        private ViewselectSpecialtickets _viewSelectspecialtickets;
        private ViewspecialTicketchoices _viewSpecialticketsChoices;

        //
        private Model.Model _model;

        //
        private int _specialOrnormalTickets = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public Controller(View view, Model.Model model, ViewselectPaymentmethod viewSelectpaymentMethod, ViewselectSpecialorNormaltickets viewSelectspecialorNormaltickets, 
            ViewselectSpecialtickets viewSelectspecialtickets, ViewbillOrnot viewBillorNot, ViewmyAllchoices viewMyallChoices, ViewnormalTicketchoices viewNormalticketChoices, ViewselectNavigoorNot viewSelectnavigOornot,
            ViewspecialTicketchoices viewSpecialticketChoices)
        {
            _model = model;
            _model.Controller = this;

            //
            _view = view;
            _view.Controller = this;

            //
            _viewSelectpaymentMethod = viewSelectpaymentMethod;
            _viewSelectpaymentMethod.Controller = this;

            //
            _viewSelectspecialorNormaltickets = viewSelectspecialorNormaltickets;
            _viewSelectspecialorNormaltickets.Controller = this;

            //
            _viewSelectspecialtickets = viewSelectspecialtickets;
            _viewSelectspecialtickets.Controller = this;

            //
            _viewBillorNot = viewBillorNot;
            _viewBillorNot.Controller = this;

            //
            _viewMyallChoices = viewMyallChoices;
            _viewMyallChoices.Controller = this;

            //
            _viewNormalticketChoices = viewNormalticketChoices;
            _viewNormalticketChoices.Controller = this;

            //
            _viewSpecialticketsChoices = viewSpecialticketChoices;
            _viewSpecialticketsChoices.Controller = this;

            //
            _viewSelectnavigoOrnot = viewSelectnavigOornot;
            _viewSelectnavigoOrnot.Controller = this;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="hide"></param>
        /// <param name="show"></param>
        public void HideShow(Form hide, Form show)
        {
            hide.Hide();
            show.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectNavigoOrnot()
        {
            HideShow(_view, _viewSelectnavigoOrnot);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialtickets()
        {
            HideShow(_viewSelectnavigoOrnot, _viewSelectspecialtickets);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewSpecialticketChoices()
        {
            HideShow(_viewSelectspecialtickets, _viewSpecialticketsChoices);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialticket()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewSelectspecialtickets);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialorNormaltickets()
        {
            HideShow(_viewSelectnavigoOrnot, _viewSelectspecialorNormaltickets);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewallMychoicestoViewspecialTicketChoices()
        {
            HideShow(_viewSpecialticketsChoices, _viewMyallChoices);
            _specialOrnormalTickets = 2;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectPaymentMethod()
        {
            HideShow(_viewMyallChoices, _viewSelectpaymentMethod);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewbillOrnot()
        {
            HideShow(_viewSelectpaymentMethod, _viewBillorNot);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewnormalTicketChoices()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewNormalticketChoices);
        }




        /// <summary>
        /// 
        /// </summary>
        public void ShowViewallMychoicestoViewnormalTicketChoices()
        {
            HideShow(_viewNormalticketChoices, _viewMyallChoices);
            _specialOrnormalTickets = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewtoViewbillOrnot()
        {
            HideShow(_viewBillorNot, _view);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewtoViewselectPaymentMethod()
        {
            HideShow(_viewSelectpaymentMethod, _view);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewtoViewallMychoices()
        {
            HideShow(_viewMyallChoices, _view);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewtoViewsSpecialticketChoices()
        {
            HideShow(_viewSpecialticketsChoices, _view);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewtoViewselectSpecialtickets()
        {
            HideShow(_viewSelectspecialtickets, _view);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewtoViewselectNavigoOrnot()
        {
            HideShow(_viewSelectnavigoOrnot, _view);
        }

        /// <summary>
        /// bouton stop
        /// </summary>
        public void ShowViewallmyChoicestoViewselectSpecialorNormaltickets()
        {

            HideShow(_viewMyallChoices, _viewSelectnavigoOrnot);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectNavigoorNottoViewselectSpecialorNormaltickets()
        {
            HideShow(_viewSelectspecialorNormaltickets, _viewSelectnavigoOrnot);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialorNormalticketstoViewselectSpecialticket()
        {
            HideShow(_viewSelectspecialtickets, _viewSelectspecialorNormaltickets);
        }


        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialtickettoViewspecialTicketChoices()
        {
            HideShow(_viewSpecialticketsChoices, _viewSelectspecialtickets);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialorNormalticketstoViewnormalTicketChoices()
        {
            HideShow(_viewNormalticketChoices, _viewSelectspecialorNormaltickets);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowSpecialorNormalticketChoicestoViewallmyChoices()
        {
            if(_specialOrnormalTickets == 1)
            {
                HideShow(_viewMyallChoices, _viewNormalticketChoices);
            }

            if (_specialOrnormalTickets == 2)
            {
                HideShow(_viewMyallChoices, _viewNormalticketChoices);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewallMyChoicestoViewselectPaymentmethod()
        {
            HideShow(_viewSelectpaymentMethod, _viewMyallChoices );
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowViewselectSpecialorNormaltickettoViewallMychoices()
        {
            HideShow(_viewMyallChoices, _viewSelectspecialorNormaltickets);
        }
    }
}
