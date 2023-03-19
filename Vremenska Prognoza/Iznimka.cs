using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vremenska_Prognoza
{
    class Iznimka : Exception
    {
        public Iznimka() {

        }

        public Iznimka(string poruka) : base(poruka) {

        }
    }
}
