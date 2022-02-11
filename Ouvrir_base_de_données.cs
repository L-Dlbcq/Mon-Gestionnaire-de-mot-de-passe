using Mon_Gestionnaire_de_mot_de_passe.Aide;
using Mon_Gestionnaire_de_mot_de_passe.Entités;
using System.Text.Json;

namespace Mon_Gestionnaire_de_mot_de_passe
{
    public partial class Ouvrir_base_de_données : Form
    {
        private string dbFile;
        public Ouvrir_base_de_données(string dbFile)
        {
            InitializeComponent();
            this.dbFile = dbFile;
            Text = $" - {Path.GetFileName(dbFile)}";
        }

        private void Afficher_mdp(object sender, EventArgs e)
        {
            Saisir_mdp_maitre_txtbox.UseSystemPasswordChar = !Saisir_mdp_maitre_txtbox.UseSystemPasswordChar;
        }

        private void Accepter(object sender, EventArgs e)
        {
            var hash = Sécurité.GetHash(Saisir_mdp_maitre_txtbox.Text);
            var fichier = Sécurité.DecryptFile(hash, dbFile);

            if (!string.IsNullOrWhiteSpace(fichier))
            {
                var json = File.ReadAllText(fichier);
                File.Delete(fichier);
                ((MainForm)Owner).base_de_données = JsonSerializer.Deserialize<Base_de_données>(json);
                ((MainForm)Owner).base_de_données.Hash = hash;
            }
            else
            {
                MessageBox.Show("Le mot de passe est invalide", "Mon Gestionnaire de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Saisir_mdp_maitre_txtbox.Clear();
                DialogResult = DialogResult.None;
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Saisir_mdp_maitre_txtbox.Select();
        }
    }
}
