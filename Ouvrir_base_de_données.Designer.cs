namespace Mon_Gestionnaire_de_mot_de_passe
{
    partial class Ouvrir_base_de_données
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
            this.Saisir_mdp_maitre_txtbox = new System.Windows.Forms.TextBox();
            this.Saisir_mdp_maitre_label = new System.Windows.Forms.Label();
            this.Afficher_mdp_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Annuler_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Saisir_mdp_maitre_txtbox
            // 
            this.Saisir_mdp_maitre_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Saisir_mdp_maitre_txtbox.Location = new System.Drawing.Point(155, 13);
            this.Saisir_mdp_maitre_txtbox.Name = "Saisir_mdp_maitre_txtbox";
            this.Saisir_mdp_maitre_txtbox.Size = new System.Drawing.Size(144, 23);
            this.Saisir_mdp_maitre_txtbox.TabIndex = 0;
            this.Saisir_mdp_maitre_txtbox.UseSystemPasswordChar = true;
            // 
            // Saisir_mdp_maitre_label
            // 
            this.Saisir_mdp_maitre_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Saisir_mdp_maitre_label.AutoSize = true;
            this.Saisir_mdp_maitre_label.Location = new System.Drawing.Point(3, 17);
            this.Saisir_mdp_maitre_label.Name = "Saisir_mdp_maitre_label";
            this.Saisir_mdp_maitre_label.Size = new System.Drawing.Size(146, 15);
            this.Saisir_mdp_maitre_label.TabIndex = 2;
            this.Saisir_mdp_maitre_label.Text = "Saisir mot de passe maitre";
            // 
            // Afficher_mdp_btn
            // 
            this.Afficher_mdp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Afficher_mdp_btn.Location = new System.Drawing.Point(305, 13);
            this.Afficher_mdp_btn.Name = "Afficher_mdp_btn";
            this.Afficher_mdp_btn.Size = new System.Drawing.Size(84, 23);
            this.Afficher_mdp_btn.TabIndex = 4;
            this.Afficher_mdp_btn.Text = "Afficher";
            this.Afficher_mdp_btn.UseVisualStyleBackColor = true;
            this.Afficher_mdp_btn.Click += new System.EventHandler(this.Afficher_mdp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Controls.Add(this.Saisir_mdp_maitre_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Afficher_mdp_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Saisir_mdp_maitre_txtbox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 49);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Annuler_btn
            // 
            this.Annuler_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler_btn.Location = new System.Drawing.Point(326, 80);
            this.Annuler_btn.Name = "Annuler_btn";
            this.Annuler_btn.Size = new System.Drawing.Size(75, 23);
            this.Annuler_btn.TabIndex = 4;
            this.Annuler_btn.Text = "Annuler";
            this.Annuler_btn.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            this.OK_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_btn.Location = new System.Drawing.Point(245, 80);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 3;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.Accepter);
            // 
            // Ouvrir_base_de_données
            // 
            this.AcceptButton = this.OK_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Annuler_btn;
            this.ClientSize = new System.Drawing.Size(413, 110);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Annuler_btn);
            this.Controls.Add(this.OK_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ouvrir_base_de_données";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saisir le mot de passe maitre";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox Saisir_mdp_maitre_txtbox;
        private Label Saisir_mdp_maitre_label;
        private Button Afficher_mdp_btn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Annuler_btn;
        private Button OK_btn;
    }
}