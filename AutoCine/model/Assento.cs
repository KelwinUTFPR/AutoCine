using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCine.model
{
    public class Assento
    {
             public string nome { get; set; }
            public string nmr_assento { get; set; }
            public string nmr_sala { get; set; }
            public string selecionado { get; set; }

            public Assento(string idc, string nmrc, string salac, string selecionadoc)
            {
                nome = idc;
                nmr_assento = nmrc;
                nmr_sala = salac;
                selecionado = selecionadoc;
            }

    }
}




