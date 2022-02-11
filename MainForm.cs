using Mon_Gestionnaire_de_mot_de_passe.Aide;
using Mon_Gestionnaire_de_mot_de_passe.Entités;
using System.ComponentModel;

namespace Mon_Gestionnaire_de_mot_de_passe
{
    public partial class MainForm : Form
    {
        public Base_de_données base_de_données;

        private const int tableau_de_donnés_mdp_colonne_index = 2;
        private const int tableau_de_donnés_mdp_nombre_de_caractère = 8;
        private Configuration configuration;
        private Entrées Entrée_séléctionnée;
        public MainForm()
        {
            InitializeComponent();
            base_de_données = new();
            configuration = new();

            Load += OnFormLoad;
            Shown += OnFormShown;
            FormClosing += OnFormClosing;
        }

        private void Entrées_Séléctionnées()
        {
            Entrée_séléctionnée = (Entrées)Tableau_de_données.CurrentRow.DataBoundItem;
        }

        #region Methode_Evenement_Formulaires
        private void OnFormLoad(object sender, EventArgs e)
        {
            configuration = Aide_Configuration.Charger_config();

            if (!File.Exists(configuration.Dern_fichier_conf))
            {
                configuration.Dern_fichier_conf = null;
            }
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            if (configuration.Dern_fichier_conf is not null)
            {
                Ouvrir_base_de_données ouvrir_Base_De_Données = new(configuration.Dern_fichier_conf);
                if (ouvrir_Base_De_Données.ShowDialog(this) == DialogResult.OK)
                {
                    Tableau_de_données.DataSource = base_de_données.Entrées;
                    Text = $"Mon Gestionnaire de mot de passe - {Path.GetFileName(configuration.Dern_fichier_conf)}";
                }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Aide_Configuration.Sauver_configuration(configuration);
        }
        #endregion

        #region Methode_Entrées
        private void Ajouter_une_entrée(object sender, EventArgs e)
        {
            Entrer_données entrer_Données = new();

            if (entrer_Données.ShowDialog(this) == DialogResult.OK)
            {
                base_de_données.Entrées.Add(entrer_Données.Entrées);
                Aide_Base_de_données.Sauver_Base_de_données(configuration.Dern_fichier_conf, base_de_données);
            }


        }
        private void Modifier_Entrée(object sender, EventArgs e)
        {
            if (Tableau_de_données.SelectedRows.Count == 1)
            {
                Entrées_Séléctionnées();
                Entrer_données entrées = new(Entrée_séléctionnée);
                Entrée_séléctionnée.Mot_de_passe = Sécurité.Decrypt(Entrée_séléctionnée.Mot_de_passe, base_de_données.Hash);

                if (entrées.ShowDialog(this) == DialogResult.OK)
                {
                    Tableau_de_données.RefreshEdit();
                    Entrée_séléctionnée.Mot_de_passe = Sécurité.Encrypt(Entrée_séléctionnée.Mot_de_passe, base_de_données.Hash);
                    Aide_Base_de_données.Sauver_Base_de_données(configuration.Dern_fichier_conf, base_de_données);
                }

            }
        }

        private void Menu_Contexte_Supprimer_entrée(object sender, EventArgs e)
        {
            Entrées_Séléctionnées();
            var résultat_demande_utilisateur = MessageBox.Show($"Vous êtes sur le point de supprimer l'entrée {Entrée_séléctionnée.Titre}. \n\n " +
                $"Voulez vous continuer ?", "Mon Gestionnaire de mot de passe", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (résultat_demande_utilisateur == DialogResult.OK)
            {
                base_de_données.Entrées.Remove(Entrée_séléctionnée);
                MessageBox.Show("L'entrée a été supprimé");
                Aide_Base_de_données.Sauver_Base_de_données(configuration.Dern_fichier_conf, base_de_données);
            }

        }
        #endregion

        #region Methode_Base_de_données
        private void Nouveau_fichier_données(object sender, EventArgs e)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            SaveFileDialog sfd = new();
            sfd.FileName = userName + ".mgmdp";
            sfd.Filter = "Fichier MGMDP de Mon Gestionnaire de mot de passe | *.mgmdp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                Nouveau_fichier_données nouveau_Fichier_Données = new();

                if (nouveau_Fichier_Données.ShowDialog(this) == DialogResult.OK)
                {
                    base_de_données.Entrées = new BindingList<Entrées>();
                    Tableau_de_données.DataSource = base_de_données.Entrées;
                    configuration.Dern_fichier_conf = dbFile;

                    Aide_Base_de_données.Sauver_Base_de_données(dbFile, base_de_données);

                    Text = $" Mon Gestionnaire de mot de passe - {Path.GetFileName(dbFile) }";
                }
            }
        }

        private void Ouvrir_base_de_données(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
                OpenDatabaseForm(ofd.FileName);

        }

        private void OpenDatabaseForm(string dbFile)
        {
            Ouvrir_base_de_données ouvrir_Base_De_Données = new(dbFile);

            if (ouvrir_Base_De_Données.ShowDialog(this) == DialogResult.OK)
            {
                Tableau_de_données.DataSource = base_de_données.Entrées;
                Text = $"Mon Gestionnaire de mot de passe - {Path.GetFileName(dbFile)}";
                configuration.Dern_fichier_conf = dbFile;

            }
        }

        private void Sauver_base_de_données(object sender, EventArgs e)
        {
            Aide_Base_de_données.Sauver_Base_de_données(configuration.Dern_fichier_conf, base_de_données);
        }
        private void Verrouillage_espace_travail(object sender, EventArgs e)
        {
            base_de_données = new();
            Tableau_de_données.DataSource = null;
            Text = $"Mon Gestionnaire de mot de passe";
            OpenDatabaseForm(configuration.Dern_fichier_conf);
        }
        private void Fermer_base_de_données(object sender, EventArgs e)
        {
            base_de_données = new();
            Tableau_de_données.DataSource = null;
            Text = $"Mon Gestionnaire de mot de passe";
            configuration.Dern_fichier_conf = null;
        }
        #endregion

        #region Methode_Menue_Fichier
        private void Ouvrir_Menu_Fichier(object sender, EventArgs e)
        {
            if (base_de_données.Hash is not null)
                Activer_Menu_Fichier(isEnabled: true);

            else
                Activer_Menu_Fichier(isEnabled: false);

        }

        private void Activer_Menu_Fichier(bool isEnabled)
        {
            Fermer_db_btn.Enabled = isEnabled;
            Verouillage_espace_travail_btn.Enabled = isEnabled;
            Enregistrer_db_btn.Enabled = isEnabled;
        }
        #endregion

        #region Methode_Menue_Entrées
        private void Ouvrir_Menu_Entrées(object sender, EventArgs e)
        {
            if (base_de_données.Hash is not null)
                Activer_Menu_Entrées(isEnabled: true);
            else
                Activer_Menu_Entrées(isEnabled: false);
        }
        private void Activer_Menu_Entrées(bool isEnabled)
        {
            Ajouter_nouvelle_entrée_btn.Enabled = isEnabled;
            Copier_mdp_btn.Enabled = isEnabled;
            Copier_user_btn.Enabled = isEnabled;
        }
        #endregion

        #region Methode_Menue_Icone
        private void Afficher_Menue_Icone(bool isEnabled)
        {
            Ver_esp_travail_menu_icone_btn.Enabled = isEnabled;
            Quitter_menu_icone_btn.Enabled = isEnabled;
        }
        #endregion

        #region Methode_Copie
        private void Copier_nom_utilisateur(object sender, EventArgs e)
        {
            Entrées_Séléctionnées();

            if (Entrée_séléctionnée != null)
            {
                Clipboard.SetText(Entrée_séléctionnée.Utilisateur);
            }
        }

        private void Copier_mdp(object sender, EventArgs e)
        {
            Entrées_Séléctionnées();

            if (Entrée_séléctionnée != null)
            {
                Clipboard.SetText(Sécurité.Decrypt(Entrée_séléctionnée.Mot_de_passe, base_de_données.Hash));
            }
        }
        #endregion



        private void Quitter_Application(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Format_cellule_tableau_base_de_données(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == tableau_de_donnés_mdp_colonne_index)
            {
                e.Value = new string('●', tableau_de_donnés_mdp_nombre_de_caractère);
            }
        }

        private void Ouvrir_Menue_Icone(object sender, CancelEventArgs e)
        {
            if (base_de_données.Hash is null)
            {
                Ver_esp_travail_menu_icone_btn.Enabled = false;
            }
            else
            {
                Ver_esp_travail_menu_icone_btn.Enabled = true;
            }
        }

    }
}