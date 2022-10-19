using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCine.model
{
    public class Filme
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Sinopse { get; set; }
        public string Genero { get; set; }
        public string Duracao { get; set; }
    }
}
