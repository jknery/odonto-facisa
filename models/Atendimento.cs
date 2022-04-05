using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.models
{
    internal class Atendimento
    {
        public string Id { get; set; }

        public string DateAtendimento { get; set; }

        public List<Procedimento> Procedimentos { get; set; }

        public Paciente Paciente { get; set; }

        public Atendimento(string dateAtendimento, List<Procedimento> procedimentos, Paciente paciente)
        {
            this.Id = procedimentos.GetHashCode().ToString() + paciente.GetHashCode().ToString() + dateAtendimento;
            this.DateAtendimento = dateAtendimento;
            this.Procedimentos = procedimentos;
            this.Paciente = paciente;
        }

        public Atendimento()
        {
        }

        public void ToString()
        {
            Console.WriteLine("## Data do Atendimento\t|\tCódigo\t|\tNome\t|\tPreço (R$)\t##");
            //Console.WriteLine("## %s\t%s\t%s\t%.2f", this.DateAtendimento, this.);
        }
    }
}
