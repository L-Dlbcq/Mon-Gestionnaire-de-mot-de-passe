using Mon_Gestionnaire_de_mot_de_passe.Entités;
using System.Text.Json;

namespace Mon_Gestionnaire_de_mot_de_passe.Aide
{
    public static class Aide_Base_de_données
    {
        public static void Sauver_Base_de_données(string path, Base_de_données base_de_données)
        {
            var fichier_Temp = Guid.NewGuid().ToString() + ".tmpMGMDP";
            var fichier_Temp_location = Path.Combine(Path.GetTempPath(), fichier_Temp);
            File.WriteAllText(fichier_Temp_location, JsonSerializer.Serialize(base_de_données));
            Sécurité.EncryptFile(base_de_données.Hash, fichier_Temp_location, path);
            File.Delete(fichier_Temp_location);
        }
    }
}
