namespace Mon_Gestionnaire_de_mot_de_passe
{
    partial class Entrer_données
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
            this.Annuler_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.URL_txtbox = new System.Windows.Forms.TextBox();
            this.Confirmation_txtbox = new System.Windows.Forms.TextBox();
            this.Mdp_txtbox = new System.Windows.Forms.TextBox();
            this.Nom_utilisateur_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titre_txtbox = new System.Windows.Forms.TextBox();
            this.Afficher_mdp_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Annuler_btn
            // 
            this.Annuler_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler_btn.Location = new System.Drawing.Point(482, 203);
            this.Annuler_btn.Name = "Annuler_btn";
            this.Annuler_btn.Size = new System.Drawing.Size(75, 23);
            this.Annuler_btn.TabIndex = 6;
            this.Annuler_btn.Text = "Annuler";
            this.Annuler_btn.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            this.OK_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_btn.Location = new System.Drawing.Point(401, 203);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 5;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.Accepter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.URL_txtbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Confirmation_txtbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Mdp_txtbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Nom_utilisateur_txtbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Titre_txtbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Afficher_mdp_btn, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 185);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // URL_txtbox
            // 
            this.URL_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.URL_txtbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.URL_txtbox.Location = new System.Drawing.Point(184, 155);
            this.URL_txtbox.Name = "URL_txtbox";
            this.URL_txtbox.Size = new System.Drawing.Size(175, 23);
            this.URL_txtbox.TabIndex = 4;
            // 
            // Confirmation_txtbox
            // 
            this.Confirmation_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirmation_txtbox.Location = new System.Drawing.Point(184, 118);
            this.Confirmation_txtbox.Name = "Confirmation_txtbox";
            this.Confirmation_txtbox.Size = new System.Drawing.Size(175, 23);
            this.Confirmation_txtbox.TabIndex = 3;
            this.Confirmation_txtbox.UseSystemPasswordChar = true;
            // 
            // Mdp_txtbox
            // 
            this.Mdp_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Mdp_txtbox.Location = new System.Drawing.Point(184, 81);
            this.Mdp_txtbox.Name = "Mdp_txtbox";
            this.Mdp_txtbox.Size = new System.Drawing.Size(175, 23);
            this.Mdp_txtbox.TabIndex = 2;
            this.Mdp_txtbox.UseSystemPasswordChar = true;
            // 
            // Nom_utilisateur_txtbox
            // 
            this.Nom_utilisateur_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nom_utilisateur_txtbox.Location = new System.Drawing.Point(184, 44);
            this.Nom_utilisateur_txtbox.Name = "Nom_utilisateur_txtbox";
            this.Nom_utilisateur_txtbox.Size = new System.Drawing.Size(175, 23);
            this.Nom_utilisateur_txtbox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adresse (URL)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirmation du mot de passe";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // Titre_txtbox
            // 
            this.Titre_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titre_txtbox.Location = new System.Drawing.Point(184, 7);
            this.Titre_txtbox.Name = "Titre_txtbox";
            this.Titre_txtbox.Size = new System.Drawing.Size(175, 23);
            this.Titre_txtbox.TabIndex = 0;
            // 
            // Afficher_mdp_btn
            // 
            this.Afficher_mdp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Afficher_mdp_btn.Location = new System.Drawing.Point(365, 81);
            this.Afficher_mdp_btn.Name = "Afficher_mdp_btn";
            this.Afficher_mdp_btn.Size = new System.Drawing.Size(175, 23);
            this.Afficher_mdp_btn.TabIndex = 7;
            this.Afficher_mdp_btn.Text = "Afficher";
            this.Afficher_mdp_btn.UseVisualStyleBackColor = true;
            this.Afficher_mdp_btn.Click += new System.EventHandler(this.Afficher_mdp);
            // 
            // Entrer_données
            // 
            this.AcceptButton = this.OK_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Annuler_btn;
            this.ClientSize = new System.Drawing.Size(569, 234);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Annuler_btn);
            this.Controls.Add(this.OK_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrer_données";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une nouvelle entrée";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Annuler_btn;
        private Button OK_btn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button Afficher_mdp_btn;
        private TextBox Titre_txtbox;
        private TextBox Nom_utilisateur_txtbox;
        private TextBox Mdp_txtbox;
        private TextBox Confirmation_txtbox;
        private TextBox URL_txtbox;
    }
}