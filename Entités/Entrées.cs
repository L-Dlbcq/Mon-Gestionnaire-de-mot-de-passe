using System.ComponentModel;

namespace Mon_Gestionnaire_de_mot_de_passe.Entités
{
    public class Entrées : ICloneable
    {
        private string uuid;
        [Browsable(false)]
        public string UUID
        {
            get => uuid;
            set => uuid = value;
        }
        private string titre;
        [DisplayName("Titre")]
        public string Titre
        {
            get => titre;
            set => titre = value;
        }

        private string utilisateur;
        [DisplayName("Identifiant")]
        public string Utilisateur
        {
            get => utilisateur;
            set => utilisateur = value;
        }
        private string mot_de_passe;
        [DisplayName("Mot de passe")]
        public string Mot_de_passe
        {
            get => mot_de_passe;
            set => mot_de_passe = value;
        }

        private string url;
        [DisplayName("Adresse (URL)")]
        public string URL
        {
            get => url;
            set => url = value;
        }

        private DateTime date_créa;
        [DisplayName("Date de création")]
        public DateTime Date_de_création
        {
            get => date_créa;
            set => date_créa = value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
