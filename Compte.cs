using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Compte
    {
        private Client Client;
        private readonly int numc;
        private int Cpt;
        private Devise solde;
        private List<Operations> op;

        public Compte()
        {

        }
        public Compte(Client c, Devise d)
        {
            this.numc = ++this.Cpt;
            this.Client = c;
            this.solde = d;


        }
        public void afficher()
        {
            Console.WriteLine("les informarion du compte:" + this.numc);
            this.Client.afficher();
            this.solde.afficher();
            Console.ReadKey();
        }
        public virtual void Crediter(Devise D)
        {
            this.solde = this.solde + D;
            Operations OP = new Operations(D, "+");
            this.op.Add(OP);
        }
        public virtual bool Debiter(Devise D)
        {
            Devise Plafond = new Devise(10);


            if (D < Plafond)
            {
                this.solde = this.solde - D;
                Operations OP = new Operations(D, "+");
                this.op.Add(OP);
                return true;
            }
            else
            {
                Console.WriteLine("ERR:impossible d'effectuer ce retrait !");
                Console.ReadKey();
                return false;
            }
        }
        public virtual bool transfererargent(Compte c, Devise D)
        {
            if (this.Debiter(D))
            {
                c.Crediter(D);
                return true;
            }
            else
            {
                Console.WriteLine("ERR:impossible d'effectuer le virement!");
                Console.ReadKey();
                return false;
            }

        }
        public void calinteret(double i)
        {
            this.solde += this.solde * i;

        }
        public bool Decouvert(Devise dec, Devise m)
        {
            return (dec + this.solde > m);
        }
        public bool checksolde(Devise d)
        {
            return this.solde / 2 > d;
        }

    } 



}
