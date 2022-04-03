using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.models
{
    internal class Paciente
    {
        public string? Cpf { get => cpf; set => cpf = value; }

        public string? Nome { get => nome; set => nome = value; }

        public string? Telefone { get => telefone; set => telefone = value; }

        public List<Atendimento>? Atendimentos { get => atendimentos; set => atendimentos = value; }

        private List<Atendimento>? atendimentos;
        private string? cpf;
        private string? telefone;
        private string? nome;

        public Paciente()
        {
            this.Atendimentos = new List<Atendimento>();
        }

        public static void MenuCadastrarPaciente()
        {


        }
    }
}
