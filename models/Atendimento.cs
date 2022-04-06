using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.models
{
    internal class Atendimento
    {
        private List<Historico> list;

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

        public List<Historico> GetHistorico()
        {
            list = new List<Historico>();

            Procedimentos.ForEach(p => {
                list.Add(new Historico(DateAtendimento, Paciente.Nome, p.Codigo, (double)p.Preco));
            });

            return list;
        }

    }
}
