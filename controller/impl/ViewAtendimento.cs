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

        public static void getHistoryByCpf()
        {
            String cpf;
            char opcao;

            Atendimento? atendimento = null;

            do
            {
                Console.Clear();
                Console.WriteLine("#############################################################");
                Console.WriteLine("##        OdontoFacisa - Histórico de Atendimento          ##");
                Console.WriteLine("##---------------------------------------------------------##");
                Console.WriteLine("## Digite o CPF do Paciente:                               ##");
                cpf = Console.ReadLine();


                try
                {
                    atendimento = atendimentoMemory.Get(cpf);
                    opcao = 'N';
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("##-----------------------------------------------------##");
                    Console.WriteLine("## Deseja tentar outro CPF? (S) | (N)                  ##");
                    opcao = Char.ToUpper(Char.Parse(Console.ReadLine()));
                }

            }while (opcao.Equals('S'));
        }

        private static void mountHistorico(Atendimento? atendimento)
        {
            Console.Clear();
            Console.WriteLine("##############################################################################################");
            Console.WriteLine("##                            OdontoFacisa - Histórico de Atendimento                       ##");
            Console.WriteLine("##------------------------------------------------------------------------------------------##");
            Console.WriteLine("## Data do Atendimento   |    Código      |        Nome        |     Preço (R$)             ##");

        }

        public override void ShowMenuSave()
        {
            string cpf, codigo, data;

            Console.Clear();
     
            Paciente paciente = this.getPaciente();

            List<Procedimento> procsList = this.getProcedimentos();

            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite a Data da Realização:              ##");
            data = Console.ReadLine();

            atendimentoMemory.Save(new Atendimento(data, procsList, paciente));
        }

        private Paciente getPaciente()
        {
            string cpf;
            char opcao;

            Paciente? paciente = null;

            do
            {
                Console.Clear();
                Console.WriteLine("#############################################################");
                Console.WriteLine("##         OdontoFacisa - Registro de Atendimento          ##");
                Console.WriteLine("##---------------------------------------------------------##");
                Console.WriteLine("## Digite o CPF do Paciente p/ atendimento:                ##");
                cpf = Console.ReadLine();

                try
                {
                    paciente = pacienteMemory.Get(cpf);
                    opcao = 'N';
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("##-----------------------------------------------------##");
                    Console.WriteLine("## Deseja tentar outro CPF? (S) | (N)                  ##");
                    opcao = Char.ToUpper(Char.Parse(Console.ReadLine()));
                }

            } while (opcao.Equals('S'));

            return paciente;
        }

        private List<Procedimento> getProcedimentos()
        {
            string codigo;
            char opcao;

            List<Procedimento> procsList = new();

            do
            {
                Console.Clear();
                Console.WriteLine("#############################################################");
                Console.WriteLine("##         OdontoFacisa - Registro de Atendimento          ##");
                Console.WriteLine("##---------------------------------------------------------##");
                Console.WriteLine("## Digite o Código do Procedimento                         ##");
                codigo = Console.ReadLine();

                try
                {
                    var proc = procedimentoMemory.Get(codigo);
                    procsList.Add(proc);
                    Console.WriteLine("##-----------------------------------------------------##");
                    Console.WriteLine("## Deseja adicionar mais algum procedimento? (S) | (N) ##");
                    opcao = Char.ToUpper(Char.Parse(Console.ReadLine()));
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("##-----------------------------------------------------##");
                    Console.WriteLine("## Deseja tentar outro código? (S) | (N)               ##");
                    opcao = Char.ToUpper(Char.Parse(Console.ReadLine()));
                }
               
            } while(opcao.Equals('S'));

            return procsList;
        }

        public override InMemory<Atendimento> getRepository()
        {
            return atendimentoMemory;
        }
    }
}
