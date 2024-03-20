using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCom
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneNaiss;

        public string Nom { get => nom; set => nom=value; }
        public string Prenom { get => prenom; set => prenom=value; }
        public int AnneNaiss { get => anneNaiss; set => anneNaiss=value; }

        public Commercial(string nomC, string prenomC, int anneNaissC)
        {
            this.nom=nomC;
            this.prenom=prenomC;
            this.anneNaiss=anneNaissC;
        }
        public double calculAge()
        {
            return 2024 - this.anneNaiss;
        }


}
