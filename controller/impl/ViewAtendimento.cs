using odonto_facisa.dao;
using odonto_facisa.dao.impl;
using odonto_facisa.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.controller.impl
{
    internal class ViewAtendimento : View<Atendimento>
    {
        private static InMemory<Atendimento> atendimentoMemory = new InMemoryAtendimento();

        private static InMemory<Paciente> pacienteMemory;

        private static InMemory<Procedimento> procedimentoMemory;
       

        public ViewAtendimento(InMemory<Paciente> paciente, InMemory<Procedimento> procedimento)
        {
            pacienteMemory = paciente;
            procedimentoMemory = procedimento;
        }

        public override void ShowMenuDelete()
        {
            throw new NotImplementedException();
        }

        public override void ShowMenuGet()
        {
            throw new NotImplementedException();
        }

        public override void ShowMenuGetAll()
        {
            throw new NotImplementedException();
        }

        public override void ShowMenuSave()
        {
            string cpf, codigo, data;

            Console.Clear();
            Console.WriteLine("###############################################");
            Console.WriteLine("##   OdontoFacisa - Registro de Atendimento  ##");
            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o CPF do Paciente p/ atendimento:  ##");
            cpf = Console.ReadLine();



            Console.Clear();
            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o Código do Procediment:           ##");
            codigo = Console.ReadLine();




            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite a Data da Realização:              ##");
            data = Console.ReadLine();

            atendimentoMemory.Save(new Atendimento());
        }

        private void getProcedimentos()
        {
            string codigo, opcao;

            List<Procedimento> procsList = new();

            do
            {
                Console.Clear();
                Console.WriteLine("##-------------------------------------------##");
                Console.WriteLine("## Digite o Código do Procediment:           ##");
                codigo = Console.ReadLine();

                var proc = procedimentoMemory.Get(codigo);
                procsList.Add(proc);

                Console.WriteLine("##-------------------------------------------##");
                Console.WriteLine("## Deseja adicionar mais algum procedimento? ##");
                opcao = Console.ReadLine();

            } while(procsList.Count > 0);
        }

        public override InMemory<Atendimento> getRepository()
        {
            return atendimentoMemory;
        }
    }
}
