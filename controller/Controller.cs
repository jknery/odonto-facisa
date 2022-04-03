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

        InMemory<Paciente> pacienteMemory = new InMemoryPaciente();

        public static int SelectAction(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadastrar Pacientes1");

                    break;

                case 2:
                    Console.WriteLine("Cadastrar Pacientes2");

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

            return opcao;

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

   
    }
}
