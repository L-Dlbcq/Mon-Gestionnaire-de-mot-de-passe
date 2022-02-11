namespace Mon_Gestionnaire_de_mot_de_passe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Barre_de_Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Fichier_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Nouveau_db_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Ouvrir_db_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Fermer_db_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Enregistrer_db_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Verouillage_espace_travail_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Quitter_app_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Entrées_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Ajouter_nouvelle_entrée_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Copier_user_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Copier_mdp_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Tableau_de_données = new System.Windows.Forms.DataGridView();
            this.Menu_contexte_tableau = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_Contexte_Copier_nom_utilisateur_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Contexte_Copier_mdp_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Contexte_Ajouter_entrée_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Contexte_Modifier_entrée_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Contexte_Supprimer_entrée_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Icone_notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu_contexte_Icone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Ver_esp_travail_menu_icone_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Quitter_menu_icone_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Barre_de_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tableau_de_données)).BeginInit();
            this.Menu_contexte_tableau.SuspendLayout();
            this.Menu_contexte_Icone.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barre_de_Menu
            // 
            resources.ApplyResources(this.Barre_de_Menu, "Barre_de_Menu");
            this.Barre_de_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Fichier_btn,
            this.Menu_Entrées_btn});
            this.Barre_de_Menu.Name = "Barre_de_Menu";
            // 
            // Menu_Fichier_btn
            // 
            resources.ApplyResources(this.Menu_Fichier_btn, "Menu_Fichier_btn");
            this.Menu_Fichier_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nouveau_db_btn,
            this.Ouvrir_db_btn,
            this.Fermer_db_btn,
            this.Enregistrer_db_btn,
            this.Verouillage_espace_travail_btn,
            this.Quitter_app_btn});
            this.Menu_Fichier_btn.Name = "Menu_Fichier_btn";
            this.Menu_Fichier_btn.DropDownOpening += new System.EventHandler(this.Ouvrir_Menu_Fichier);
            // 
            // Nouveau_db_btn
            // 
            resources.ApplyResources(this.Nouveau_db_btn, "Nouveau_db_btn");
            this.Nouveau_db_btn.Name = "Nouveau_db_btn";
            this.Nouveau_db_btn.Click += new System.EventHandler(this.Nouveau_fichier_données);
            // 
            // Ouvrir_db_btn
            // 
            resources.ApplyResources(this.Ouvrir_db_btn, "Ouvrir_db_btn");
            this.Ouvrir_db_btn.Name = "Ouvrir_db_btn";
            this.Ouvrir_db_btn.Click += new System.EventHandler(this.Ouvrir_base_de_données);
            // 
            // Fermer_db_btn
            // 
            resources.ApplyResources(this.Fermer_db_btn, "Fermer_db_btn");
            this.Fermer_db_btn.Name = "Fermer_db_btn";
            this.Fermer_db_btn.Click += new System.EventHandler(this.Fermer_base_de_données);
            // 
            // Enregistrer_db_btn
            // 
            resources.ApplyResources(this.Enregistrer_db_btn, "Enregistrer_db_btn");
            this.Enregistrer_db_btn.Name = "Enregistrer_db_btn";
            this.Enregistrer_db_btn.Click += new System.EventHandler(this.Sauver_base_de_données);
            // 
            // Verouillage_espace_travail_btn
            // 
            resources.ApplyResources(this.Verouillage_espace_travail_btn, "Verouillage_espace_travail_btn");
            this.Verouillage_espace_travail_btn.Name = "Verouillage_espace_travail_btn";
            this.Verouillage_espace_travail_btn.Click += new System.EventHandler(this.Verrouillage_espace_travail);
            // 
            // Quitter_app_btn
            // 
            resources.ApplyResources(this.Quitter_app_btn, "Quitter_app_btn");
            this.Quitter_app_btn.Name = "Quitter_app_btn";
            this.Quitter_app_btn.Click += new System.EventHandler(this.Quitter_Application);
            // 
            // Menu_Entrées_btn
            // 
            resources.ApplyResources(this.Menu_Entrées_btn, "Menu_Entrées_btn");
            this.Menu_Entrées_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ajouter_nouvelle_entrée_btn,
            this.Copier_user_btn,
            this.Copier_mdp_btn});
            this.Menu_Entrées_btn.Name = "Menu_Entrées_btn";
            this.Menu_Entrées_btn.DropDownOpening += new System.EventHandler(this.Ouvrir_Menu_Entrées);
            // 
            // Ajouter_nouvelle_entrée_btn
            // 
            resources.ApplyResources(this.Ajouter_nouvelle_entrée_btn, "Ajouter_nouvelle_entrée_btn");
            this.Ajouter_nouvelle_entrée_btn.Name = "Ajouter_nouvelle_entrée_btn";
            this.Ajouter_nouvelle_entrée_btn.Click += new System.EventHandler(this.Ajouter_une_entrée);
            // 
            // Copier_user_btn
            // 
            resources.ApplyResources(this.Copier_user_btn, "Copier_user_btn");
            this.Copier_user_btn.Name = "Copier_user_btn";
            this.Copier_user_btn.Click += new System.EventHandler(this.Copier_nom_utilisateur);
            // 
            // Copier_mdp_btn
            // 
            resources.ApplyResources(this.Copier_mdp_btn, "Copier_mdp_btn");
            this.Copier_mdp_btn.Name = "Copier_mdp_btn";
            this.Copier_mdp_btn.Click += new System.EventHandler(this.Copier_mdp);
            // 
            // Tableau_de_données
            // 
            resources.ApplyResources(this.Tableau_de_données, "Tableau_de_données");
            this.Tableau_de_données.AllowUserToAddRows = false;
            this.Tableau_de_données.AllowUserToDeleteRows = false;
            this.Tableau_de_données.AllowUserToResizeColumns = false;
            this.Tableau_de_données.AllowUserToResizeRows = false;
            this.Tableau_de_données.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tableau_de_données.BackgroundColor = System.Drawing.Color.White;
            this.Tableau_de_données.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tableau_de_données.ContextMenuStrip = this.Menu_contexte_tableau;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tableau_de_données.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tableau_de_données.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tableau_de_données.Name = "Tableau_de_données";
            this.Tableau_de_données.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tableau_de_données.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tableau_de_données.RowTemplate.Height = 25;
            this.Tableau_de_données.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tableau_de_données.ShowCellToolTips = false;
            this.Tableau_de_données.ShowEditingIcon = false;
            this.Tableau_de_données.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Format_cellule_tableau_base_de_données);
            // 
            // Menu_contexte_tableau
            // 
            resources.ApplyResources(this.Menu_contexte_tableau, "Menu_contexte_tableau");
            this.Menu_contexte_tableau.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Contexte_Copier_nom_utilisateur_btn,
            this.Menu_Contexte_Copier_mdp_btn,
            this.Menu_Contexte_Ajouter_entrée_btn,
            this.Menu_Contexte_Modifier_entrée_btn,
            this.Menu_Contexte_Supprimer_entrée_btn});
            this.Menu_contexte_tableau.Name = "Menu_contexte_tableau";
            // 
            // Menu_Contexte_Copier_nom_utilisateur_btn
            // 
            resources.ApplyResources(this.Menu_Contexte_Copier_nom_utilisateur_btn, "Menu_Contexte_Copier_nom_utilisateur_btn");
            this.Menu_Contexte_Copier_nom_utilisateur_btn.Name = "Menu_Contexte_Copier_nom_utilisateur_btn";
            this.Menu_Contexte_Copier_nom_utilisateur_btn.Click += new System.EventHandler(this.Copier_nom_utilisateur);
            // 
            // Menu_Contexte_Copier_mdp_btn
            // 
            resources.ApplyResources(this.Menu_Contexte_Copier_mdp_btn, "Menu_Contexte_Copier_mdp_btn");
            this.Menu_Contexte_Copier_mdp_btn.Name = "Menu_Contexte_Copier_mdp_btn";
            this.Menu_Contexte_Copier_mdp_btn.Click += new System.EventHandler(this.Copier_mdp);
            // 
            // Menu_Contexte_Ajouter_entrée_btn
            // 
            resources.ApplyResources(this.Menu_Contexte_Ajouter_entrée_btn, "Menu_Contexte_Ajouter_entrée_btn");
            this.Menu_Contexte_Ajouter_entrée_btn.Name = "Menu_Contexte_Ajouter_entrée_btn";
            this.Menu_Contexte_Ajouter_entrée_btn.Click += new System.EventHandler(this.Ajouter_une_entrée);
            // 
            // Menu_Contexte_Modifier_entrée_btn
            // 
            resources.ApplyResources(this.Menu_Contexte_Modifier_entrée_btn, "Menu_Contexte_Modifier_entrée_btn");
            this.Menu_Contexte_Modifier_entrée_btn.Name = "Menu_Contexte_Modifier_entrée_btn";
            this.Menu_Contexte_Modifier_entrée_btn.Click += new System.EventHandler(this.Modifier_Entrée);
            // 
            // Menu_Contexte_Supprimer_entrée_btn
            // 
            resources.ApplyResources(this.Menu_Contexte_Supprimer_entrée_btn, "Menu_Contexte_Supprimer_entrée_btn");
            this.Menu_Contexte_Supprimer_entrée_btn.Name = "Menu_Contexte_Supprimer_entrée_btn";
            this.Menu_Contexte_Supprimer_entrée_btn.Click += new System.EventHandler(this.Menu_Contexte_Supprimer_entrée);
            // 
            // Icone_notification
            // 
            resources.ApplyResources(this.Icone_notification, "Icone_notification");
            this.Icone_notification.ContextMenuStrip = this.Menu_contexte_Icone;
            // 
            // Menu_contexte_Icone
            // 
            resources.ApplyResources(this.Menu_contexte_Icone, "Menu_contexte_Icone");
            this.Menu_contexte_Icone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ver_esp_travail_menu_icone_btn,
            this.Quitter_menu_icone_btn});
            this.Menu_contexte_Icone.Name = "Menu_contexte_Icone";
            this.Menu_contexte_Icone.Opening += new System.ComponentModel.CancelEventHandler(this.Ouvrir_Menue_Icone);
            // 
            // Ver_esp_travail_menu_icone_btn
            // 
            resources.ApplyResources(this.Ver_esp_travail_menu_icone_btn, "Ver_esp_travail_menu_icone_btn");
            this.Ver_esp_travail_menu_icone_btn.Name = "Ver_esp_travail_menu_icone_btn";
            this.Ver_esp_travail_menu_icone_btn.Click += new System.EventHandler(this.Verrouillage_espace_travail);
            // 
            // Quitter_menu_icone_btn
            // 
            resources.ApplyResources(this.Quitter_menu_icone_btn, "Quitter_menu_icone_btn");
            this.Quitter_menu_icone_btn.Name = "Quitter_menu_icone_btn";
            this.Quitter_menu_icone_btn.Click += new System.EventHandler(this.Quitter_Application);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Tableau_de_données);
            this.Controls.Add(this.Barre_de_Menu);
            this.MainMenuStrip = this.Barre_de_Menu;
            this.Name = "MainForm";
            this.Barre_de_Menu.ResumeLayout(false);
            this.Barre_de_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tableau_de_données)).EndInit();
            this.Menu_contexte_tableau.ResumeLayout(false);
            this.Menu_contexte_Icone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Barre_de_Menu;
        private ToolStripMenuItem Menu_Fichier_btn;
        private ToolStripMenuItem Nouveau_db_btn;
        private ToolStripMenuItem Ouvrir_db_btn;
        private ToolStripMenuItem Fermer_db_btn;
        private ToolStripMenuItem Enregistrer_db_btn;
        private ToolStripMenuItem Verouillage_espace_travail_btn;
        private ToolStripMenuItem Quitter_app_btn;
        private ToolStripMenuItem Menu_Entrées_btn;
        private ToolStripMenuItem Ajouter_nouvelle_entrée_btn;
        private ToolStripMenuItem Copier_user_btn;
        private ToolStripMenuItem Copier_mdp_btn;
        private DataGridView Tableau_de_données;
        private ContextMenuStrip Menu_contexte_tableau;
        private ToolStripMenuItem Menu_Contexte_Copier_nom_utilisateur_btn;
        private ToolStripMenuItem Menu_Contexte_Copier_mdp_btn;
        private ToolStripMenuItem Menu_Contexte_Ajouter_entrée_btn;
        private ToolStripMenuItem Menu_Contexte_Modifier_entrée_btn;
        private ToolStripMenuItem Menu_Contexte_Supprimer_entrée_btn;
        private NotifyIcon Icone_notification;
        private ContextMenuStrip Menu_contexte_Icone;
        private ToolStripMenuItem Ver_esp_travail_menu_icone_btn;
        private ToolStripMenuItem Quitter_menu_icone_btn;
    }
}