using System;

namespace Polymorphisme
{
    class Professeur : Personne
    {
        int Salaire { get; set; }

        public Professeur(string nom, string prenom, int age, int salaire)
            : base(nom, prenom, age)
        {
            Salaire = salaire;
        }
                
        public override void AfficherInfo()
        {
            base.AfficherInfo();
            Console.WriteLine($"Salaire : {Salaire}");
        }
    }
}
