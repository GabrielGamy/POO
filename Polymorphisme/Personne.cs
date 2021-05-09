using System;

namespace Polymorphisme
{
    class Personne
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        int Age { get; set; }

        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public virtual void AfficherInfo()
        {
            Console.WriteLine($"Nom : {Nom}, Prenom : {Prenom}, Age: { Age}");
        }
    }
}
