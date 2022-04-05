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
    internal class ViewProcedimento : View<Procedimento>
    {
        private InMemory<Procedimento> procedimentoMemory = new InMemoryProcedimento();

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
            string codigo, nome;
            double preco;

            Console.Clear();
            Console.WriteLine("###############################################");
            Console.WriteLine("##  OdontoFacisa - Cadastro de Procedimentos ##");
            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o Código do Procedimento?          ##");
            codigo = Console.ReadLine();

            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o Nome do Procedimento?            ##");
            nome = Console.ReadLine();

            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Digite o Preço do Procedimento?           ##");
            preco = Double.Parse(Console.ReadLine());

            this.procedimentoMemory.Save(new Procedimento(codigo, nome, preco));
        }

        public override InMemory<Procedimento> getRepository()
        {
            return procedimentoMemory;
        }
    }
}
