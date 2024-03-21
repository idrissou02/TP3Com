using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionCom
{
    internal class Service
    {
        private int serv;
        private int effectif;
        private Commercial[] tabCom;

        public int Serv { get => serv; set => serv=value; }

        public Service(int Serv)
        {
            this.serv = Serv;
            tabCom = new Commercial[10];
            effectif = 0;
        }
    }
}
