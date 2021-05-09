using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisme
{
    class Etudiant : Personne
    {
        string Matricule { get; set; }

        public Etudiant(string nom, string prenom, int age, string matricule)
            :base(nom, prenom, age)
        {
            Matricule = matricule;
        }

        public override void AfficherInfo()
        {
            base.AfficherInfo();
            Console.WriteLine($"Matricule : {Matricule}");
        }
    }
}
