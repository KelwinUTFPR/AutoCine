using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCine.model
{
    public class Sessao
    {
        public string id { get; set; }
        public string sala { get; set; }
        public string horario { get; set; }
        public string filme { get; set; }

        public Sessao(string idc, string salac, string horarioc, string filmec) {
            id = idc;
            sala = salac;
            horario = horarioc;
            filme = filmec;
        }
    }
}
