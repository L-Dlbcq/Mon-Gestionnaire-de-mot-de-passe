using Mon_Gestionnaire_de_mot_de_passe.Aide;
using Mon_Gestionnaire_de_mot_de_passe.Entités;

namespace Mon_Gestionnaire_de_mot_de_passe
{
    public partial class Entrer_données : Form
    {
        public Entrées Entrées;
        private Entrées initialisation_entrées;

        public Entrer_données(Entrées entrées = null)
        {
            InitializeComponent();
            if (entrées != null)
            {
                Entrées = entrées;
            }
        }

        private void Accepter(object sender, EventArgs e)
        {
            if (Confirmation_txtbox.Text.Equals(Mdp_txtbox.Text))
            {
                Entrées = new()
                {
                    UUID = Guid.NewGuid().ToString().ToUpper(),
                    Titre = Titre_txtbox.Text,
                    Utilisateur = Nom_utilisateur_txtbox.Text,
                    Mot_de_passe = Sécurité.Encrypt(Mdp_txtbox.Text, ((MainForm)Owner).base_de_données.Hash),
                    URL = URL_txtbox.Text,
                    Date_de_création = DateTime.Now
                };
            }
            else
            {
                MessageBox.Show("Les mots de passe sont différents !", "Mon Gestionaire de Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }
        private void Afficher_mdp(object sender, EventArgs e)
        {
            Mdp_txtbox.UseSystemPasswordChar = !Mdp_txtbox.UseSystemPasswordChar;
            Confirmation_txtbox.UseSystemPasswordChar = !Confirmation_txtbox.UseSystemPasswordChar;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Titre_txtbox.Select();

            if (Entrées != null)
            {
                initialisation_entrées = (Entrées)Entrées.Clone();

                Titre_txtbox.DataBindings.Add("Text", Entrées, "Titre");
                Nom_utilisateur_txtbox.DataBindings.Add("Text", Entrées, "Utilisateur");
                Mdp_txtbox.DataBindings.Add("Text", Entrées, "Mot_de_passe");
                Confirmation_txtbox.Text = Mdp_txtbox.Text;
                URL_txtbox.DataBindings.Add("Text", Entrées, "URL");
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Entrées is not null && DialogResult == DialogResult.Cancel)
            {
                Entrées.Titre = initialisation_entrées.Titre;
                Entrées.Utilisateur = initialisation_entrées.Utilisateur;
                Entrées.Mot_de_passe = initialisation_entrées.Mot_de_passe;
                Entrées.URL = initialisation_entrées.URL;
            }
        }
    }
}

