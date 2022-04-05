using odonto_facisa.controller.impl;
using odonto_facisa.dao;
using odonto_facisa.dao.impl;
using odonto_facisa.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.controller
{
    internal class Controller    {

        private static View<Paciente> viewPaciente = new ViewPaciente();

        private static View<Procedimento> viewProcedimento = new ViewProcedimento();

        private static View<Atendimento> viewAtendimento = new ViewAtendimento(viewPaciente.getRepository(), viewProcedimento.getRepository());

        public static void SelectAction(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    viewPaciente.ShowMenuSave();
                    break;

                case 2:
                    viewProcedimento.ShowMenuSave();
                    break;

                case 3:
                    Console.WriteLine("Cadastrar Pacientes3");
                    break;

                case 4:
                    Console.WriteLine("Cadastrar Pacientes4");
                    break;

                case 5:
                    break;

            }

        }

        public static int ShowMenuPrincipal()
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("###############################################");
                Console.WriteLine("##              OdontoFacisa                 ##");
                Console.WriteLine("##-------------------------------------------##");
                Console.WriteLine("## 1 - Cadastrar Paciente                    ##");
                Console.WriteLine("## 2 - Cadastrar Procedimento                ##");
                Console.WriteLine("## 3 - Registrar Atendimento                 ##");
                Console.WriteLine("## 4 - Vis. Hist. de Paciente                ##");
                Console.WriteLine("## 5 - Sair                                  ##");
                Console.WriteLine("##-------------------------------------------##");
                Console.WriteLine("## Digite a opção escolhida: ");
                opcao = int.Parse(Console.ReadLine());

            }while(opcao < 1 || opcao > 5);

            return opcao;
        }

        public static char modalWannaGoOut()
        {
            Console.Clear();
            Console.WriteLine("###############################################");
            Console.WriteLine("##              OdontoFacisa                 ##");
            Console.WriteLine("##-------------------------------------------##");
            Console.WriteLine("## Deseja Sair? (S)im | (N)ão                ##");
            return Char.ToUpper(char.Parse(Console.ReadLine()));
        }

   
    }
}
