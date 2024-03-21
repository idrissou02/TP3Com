using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCom
{
    internal class Categorie
    {
        public string codeCat;
        public string libCat;

        public string CodeCat { get => codeCat; set => codeCat=value; }
        public string LibCat { get => libCat; set => libCat=value; }

        public Categorie(string CodeCat, string LibCat)
        {
            this.codeCat = CodeCat;
            this.libCat = LibCat;
        }
        public override string ToString()
        {
            return this.codeCat+", "+this.libCat;
        }

    }
}
