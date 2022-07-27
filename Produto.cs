using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa
{
    public class Produto
    {
        public object nome_completo;

        public int id { get; set; } 
        public string nome { get; set; }

        public double preco { get; set; }

        public int id_categoria { get; set; }

        public int id_respcadastro { get; set; }

            }
}
