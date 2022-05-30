using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Operations
    {
        private int num;
        private DateTime date;
        private Devise d;
        private string lib;

        public Operations() { }
        public Operations(Devise d , string l ) {
            this.d = d;
            this.lib = l;
        }
    }
}
