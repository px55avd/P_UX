///**************************************************************************************
///ETML
///Auteur : Omar Egal Ahmed
///Date : 21.03.2024
///Description : Création d'une application d'achat de billets de trains et metro parisiens.
///utilisation du Pattern Model, View, Controler. Vous êtes actuellement dans une des vues.
///**************************************************************************************
using System;
using System.Resources;
using System.Windows.Forms;

namespace P_UX_ACD_EgalAhmeOmar
{
    public partial class View : Form
    {
        /// <summary>
        /// Constructeur de la classe ViewspecialTicketchoices.
        /// </summary>
        public View()
        {
            InitializeComponent();// Initialise les composants de la vue.
        }

        /// <summary>
        /// Constructeur de la classe ViewspecialTicketchoices
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
        /// Événement déclenché lors du clic sur le bouton "Anglais" sur la première page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnEnglishinFirstpage_Click(object sender, EventArgs e)
        {
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.English); // Définit la langue de l'application sur l'anglais.

            // Affiche la vue pour sélectionner l'utilisation du Navigo.
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Allemand" sur la première page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnDeutshinFirstpage_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'allemand.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Deutsh);

            // Affiche la vue pour sélectionner l'utilisation du Navigo.
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Espagnol" sur la première page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnSpanishinFirstpage_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'espagnol.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Spanish);

            // Affiche la vue pour sélectionner l'utilisation du Navigo.
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Italien" sur la première page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnItalianinFirstpage_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur l'italien.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.Italian);

            // Affiche la vue pour sélectionner l'utilisation du Navigo.
            Controller.ShowViewselectNavigoOrnot();
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Passer au français" sur la première page.
        /// </summary>
        /// <param name="sender">L'objet qui a déclenché l'événement.</param>
        /// <param name="e">Les arguments de l'événement.</param>
        private void btnPasstoFrench_Click(object sender, EventArgs e)
        {
            // Définit la langue de l'application sur le français.
            Controller.Lang(P_UX_ACD_EgalAhmeOmar.Controller.Controller.Language.French);

            // Affiche la vue pour sélectionner l'utilisation du Navigo.
            Controller.ShowViewselectNavigoOrnot();
        }
    }
}
