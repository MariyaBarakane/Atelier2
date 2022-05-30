using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class CompteCourant:Compte
    {
        private Devise decouvert;
        public CompteCourant() { }
        public CompteCourant(Client c , Devise d ,Devise dec) :base(c,d)
        {
            this.decouvert = dec;
        }
        public override bool Debiter(Devise d) {
            if (base.Decouvert(this.decouvert, d))
            {
                base.Debiter(d);
            }
            return false;
        }
        public override bool transfererargent(Compte c, Devise D)
        {
            if (this.Debiter(D))
            {
                c.Crediter(D);
                return true; 
            }
            Console.WriteLine("ERR:impossible d'effectuer le virement!");
            Console.ReadKey();
            return false;
        }
    }
}
