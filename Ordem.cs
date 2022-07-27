using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa
{
    public class Ordem
    {
        public int id { get; set; }

        public int id_ficha { get; set; }

        public int id_produto { get; set; }

        public int quantidade { get; set; }

        public int id_resp { get; set; }

        public int data_adic { get; set; }

        public int situacao { get; set; }

    }
}
