using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    interface IViaggiatore
    {

        string Biglietto { get; set; }

        void CompraBiglietto(string origine, string destinazione);

    }
}
