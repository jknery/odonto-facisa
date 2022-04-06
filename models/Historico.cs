using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.models
{
    internal class Historico
    {
        public string Data { get; set; }

        public string Nome { get; set; }

        public string Codigo { get; set; }

        public double Valor { get; set; }

        public Historico(string data, string nome, string codigo, double valor)
        {
            Data = data;
            Nome = nome;
            Codigo = codigo;
            Valor = valor;
        }
    }
}
