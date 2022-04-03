using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.models
{
    internal class Procedimento
    {
        public string codigo { get; set; }

        public string nome { get; set; }

        public double preco { get; set; }

        public Procedimento(string codigo, string nome, double preco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }
    }
}
