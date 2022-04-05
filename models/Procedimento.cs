using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.models
{
    internal class Procedimento
    {
        public string? Codigo { get => codigo; set => codigo = value; }

        public string? Nome { get => nome; set => nome = value; }

        public double? Preco { get => preco; set => preco = value; }

        private string? codigo;
        private string? nome;
        private double? preco;

        public Procedimento(string? codigo, string? nome, double? preco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }
    }
}
