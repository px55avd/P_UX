namespace P_UX_ACD_EgalAhmeOmar.Views
{
    partial class View2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlSelectnavigoOrnot = new System.Windows.Forms.Panel();
            this.btnPlacenavigoPass = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSelectnavigoOrnot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(221, 62);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnlSelectnavigoOrnot
            // 
            this.pnlSelectnavigoOrnot.Controls.Add(this.button2);
            this.pnlSelectnavigoOrnot.Controls.Add(this.btnPlacenavigoPass);
            this.pnlSelectnavigoOrnot.Location = new System.Drawing.Point(12, 92);
            this.pnlSelectnavigoOrnot.Name = "pnlSelectnavigoOrnot";
            this.pnlSelectnavigoOrnot.Size = new System.Drawing.Size(776, 345);
            this.pnlSelectnavigoOrnot.TabIndex = 1;
            // 
            // btnPlacenavigoPass
            // 
            this.btnPlacenavigoPass.Location = new System.Drawing.Point(13, 31);
            this.btnPlacenavigoPass.Name = "btnPlacenavigoPass";
            this.btnPlacenavigoPass.Size = new System.Drawing.Size(342, 281);
            this.btnPlacenavigoPass.TabIndex = 0;
            this.btnPlacenavigoPass.Text = "Déposer votre carte Navigo";
            this.btnPlacenavigoPass.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 281);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vous n\'avez de Carte Navigo, Appuyer ici";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // View2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSelectnavigoOrnot);
            this.Controls.Add(this.btnBack);
            this.Name = "View2";
            this.Text = "View2";
            this.pnlSelectnavigoOrnot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlSelectnavigoOrnot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlacenavigoPass;
    }
}