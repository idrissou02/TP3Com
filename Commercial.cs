using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCom
{
    internal class Commercial
    {
        public string nom;
        public string prenom;
        public int anneNaiss;
        public Categorie cat ;

        public string Nom { get => nom; set => nom=value; }
        public string Prenom { get => prenom; set => prenom=value; }
        public int AnneNaiss { get => anneNaiss; set => anneNaiss=value; }

        public Commercial(string nomC, string prenomC, int anneNaissC, Categorie catC)
        {
            this.nom=nomC;
            this.prenom=prenomC;
            this.anneNaiss=anneNaissC;
            this.cat=catC;
        }
        public double calculAge()
        {
            return DateTime.Now.Year - this.anneNaiss;
        }

        public override string ToString()
        {
            return "nom : "+this.nom+"\nprenom : "+this.prenom+"\nAnnée de naissance : "+this.anneNaiss+"\nCe commercial a donc "+calculAge()+"\nCatégorie : "+this.cat+"\n";
        }
        public void compare(Commercial c)
        {
            if (c.Nom == this.nom)
            {
                Console.WriteLine("\n Les deux commerciaux ont le même nom de famille.");
            }
            c.Nom=nom;
        }
    }
}
