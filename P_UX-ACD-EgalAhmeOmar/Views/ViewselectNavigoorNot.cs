﻿///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans une des vues.
///**************************************************************************************
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
    public partial class ViewselectNavigoorNot : Form
    {
        public ViewselectNavigoorNot()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contrôleur associé à cette vue.
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// Met à jour la langue de l'interface utilisateur en utilisant un ResourceManager.
        /// </summary>
        /// <param name="_resourcesManager">ResourceManager pour les ressources de localisation.</param>
        public void UpdateLang(ResourceManager _resourcesManager)
        {
            ResourceManager resourceManager = _resourcesManager; // Initialise le gestionnaire de ressources.

            foreach (Control c in this.Controls) // Parcourt tous les contrôles dans cette vue.
            {
                UpdateLevel(c); // Appelle la méthode pour mettre à jour les contrôles enfants.
            }

            // Traduction récursive dans les contrôles enfants
            void UpdateLevel(Control parentControl)
            {
                if (parentControl.HasChildren) // Si le contrôle a des enfants.
                {
                    foreach (Control childControl in parentControl.Controls) // Parcourt tous les enfants du contrôle.
                    {
                        UpdateLevel(childControl); // Appelle récursivement la méthode pour mettre à jour chaque enfant.
                    }
                }
                if (resourceManager.GetString(parentControl.Name) != null) // Vérifie si le nom du contrôle est une clé de ressource.
                {
                    parentControl.Text = resourceManager.GetString(parentControl.Name); // Met à jour le texte du contrôle avec la valeur de la ressource correspondante.
                }
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de retour.
        /// </summary>
        /// <param name="sender">L'objet à l'origine de l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Affiche la vue pour choisir d'avoir un pass Navigo ou non.
            Controller.ShowViewtoViewselectNavigoOrnot();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton "Je n'ai pas de pass Navigo".
        /// </summary>
        /// <param name="sender">L'objet à l'origine de l'événement.</param>
        /// <param name="e">Les données d'événement.</param>
        private void btnDonthaveNavigo_Click(object sender, EventArgs e)
        {
            // Affiche la vue pour choisir entre les billets spéciaux ou normaux.
            Controller.ShowViewselectSpecialorNormaltickets();
        }
    }
}
