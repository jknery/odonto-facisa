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
    internal class ViewPaciente: View<Paciente>
    {
        private InMemory<Paciente> pacienteMemory = new InMemoryPaciente();

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
            pacienteMemory.GetAll().ForEach(p => Console.WriteLine(p.Cpf));
        }

        public override void ShowMenuSave()
        {
            string cpf, nome, telefone;

            Console.Clear();
            Console.WriteLine("###############################################");
            Console.WriteLine("##    OdontoFacisa - Cadastro de Pacientes   ##");
            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o CPF do Paciente?                 ##");
            cpf = Console.ReadLine();

            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o Nome do Paciente?                ##");
            nome = Console.ReadLine().Chunk(16).ToString();

            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o Telefone do Paciente?            ##");
            telefone = Console.ReadLine();

            this.pacienteMemory.Save(new Paciente(cpf, telefone, nome));
        }

        public override InMemory<Paciente> getRepository()
        {
            return pacienteMemory;
        }
    }
}
