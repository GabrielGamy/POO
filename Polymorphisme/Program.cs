using System;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphisme_Overloading();
            Polymorphisme_Overriding();
        }

        static void Polymorphisme_Overloading()
        {
            Logger logger = new Logger();
            logger.LogMessage("Forme 1");
            string[] messages = new string[2] { "Forme 2", "Forme 2" };
            logger.LogMessage(messages);
        }

        static void Polymorphisme_Overriding()
        {
            Personne Ada = new Personne("Lovelace", "Ada", 36);
            Personne Andrew = new Professeur("Tanenbaum ", "Andrew", 77, 10000);
            Personne Ken = new Etudiant("Thompson", "Ken", 78, "KTH2021-C");

            Ada.AfficherInfo();
            Andrew.AfficherInfo();
            Ken.AfficherInfo();
        }
    }
}
