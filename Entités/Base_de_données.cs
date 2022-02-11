using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Mon_Gestionnaire_de_mot_de_passe.Entités
{
    public class Base_de_données
    {
        private string hash;
        [JsonIgnore]
        public string Hash
        {
            get => hash;
            set => hash = value;
        }

        private BindingList<Entrées> entrées;
        public BindingList<Entrées> Entrées
        {
            get => entrées;
            set => entrées = value;
        }
        public Base_de_données()

        {
            entrées = new BindingList<Entrées>();
        }

    }
}
