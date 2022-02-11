using Mon_Gestionnaire_de_mot_de_passe.Entités;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Mon_Gestionnaire_de_mot_de_passe.Aide
{
    public static class Aide_Configuration
    {
        private static readonly string Dossier_fichier_Config = Path.Combine("C:\\Users\\l.dolbecq\\Documents\\Fichiers de projet\\temp", "Mon Gestionnaire de mot de passe");

        private static readonly string Nom_fichier_Config = "Mon Gestionnaire de mot de passe.config.json";

        private static readonly string Chemin_fichier_config = Path.Combine(Dossier_fichier_Config, Nom_fichier_Config);

        public static void Sauver_configuration(Configuration configuration)
        {
            var JSON = JsonSerializer.Serialize(configuration, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(Dossier_fichier_Config))
                Directory.CreateDirectory(Dossier_fichier_Config);

            File.WriteAllText(Chemin_fichier_config, JSON);
        }

        public static Configuration Charger_config()
        {
            Configuration configuration = new();
            if (!Directory.Exists(Dossier_fichier_Config))
            {
                Directory.CreateDirectory(Dossier_fichier_Config);
                Sauver_configuration(configuration);

                return configuration;
            }

            var JSON = File.ReadAllText(Chemin_fichier_config);
            return JsonSerializer.Deserialize<Configuration>(JSON);
        }
    }
}
