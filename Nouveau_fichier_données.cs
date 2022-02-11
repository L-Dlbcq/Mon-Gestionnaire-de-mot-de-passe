using Mon_Gestionnaire_de_mot_de_passe.Aide;

namespace Mon_Gestionnaire_de_mot_de_passe
{
    public partial class Nouveau_fichier_données : Form
    {

        public Nouveau_fichier_données()
        {
            InitializeComponent();

        }

        private void Accepter(object sender, EventArgs e)
        {
            if (!Saisir_mdp_maitre_txtbox.Text.Equals(Confirmer_mdp_maitre_txtbox.Text))
            {
                MessageBox.Show("Les mots de passe sont différents !", "Mon Gestionaire de Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            else
            {
                ((MainForm)Owner).base_de_données.Hash = Sécurité.GetHash(Saisir_mdp_maitre_txtbox.Text);
            }

        }

        private void Afficher_mdp(object sender, EventArgs e)
        {
            Saisir_mdp_maitre_txtbox.UseSystemPasswordChar = !Saisir_mdp_maitre_txtbox.UseSystemPasswordChar;
            Confirmer_mdp_maitre_txtbox.UseSystemPasswordChar = !Confirmer_mdp_maitre_txtbox.UseSystemPasswordChar;
        }
    }
}
