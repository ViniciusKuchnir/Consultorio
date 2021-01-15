using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsultorioMédico
{
    public sealed class Paciente
    {

        private string NomePaciente { get; set; }
        private int IdadePaciente { get; set; }
        private double PesoPaciente { get; set; }
        private double AlturaPaciente { get; set; }

        private int CpfPaciente { get; set; }

        private static List<Paciente> Pacientes = new List<Paciente>();


        //Construtores

        public Paciente(string nomePaciente, int idadePaciente, float pesoPaciente, float alturaPaciente, int cpfPaciente)
        {
            this.NomePaciente = nomePaciente;
            this.IdadePaciente = idadePaciente;
            this.PesoPaciente = pesoPaciente;
            this.AlturaPaciente = alturaPaciente;
            this.CpfPaciente = cpfPaciente;
        }



        //Metodos

        public void CadastrarPaciente()
        {

            Console.WriteLine("Digite o nome do paciente");
            string nomePaciente = Console.ReadLine();

            Console.WriteLine("Digite a idade do paciente");
            int idadePaciente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o peso do paciente");
            float pesoPaciente = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a altura do paciente");
            float alturaPaciente = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o CPF do paciente");
            int cpfPaciente = Convert.ToInt32(Console.ReadLine());


            Paciente paciente = new Paciente(nomePaciente, idadePaciente, pesoPaciente, alturaPaciente, cpfPaciente);

            Pacientes.Add(paciente);

            Console.WriteLine("Deseja Cadastrar mais paciente?\n1 - Sim\n2 - Não");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha != 1)
            {
                Console.WriteLine("\nPaciente(s) Cadastrado(s) com Sucesso\n");
            }
            else
            {
                CadastrarPaciente();
            }

        }

        public void ListarPaciente()
        {

            Console.WriteLine("------Lista Pacientes--------");

            for (int i = 0; i < Pacientes.Count; i++)
            {
                Console.WriteLine(i + "-" + Pacientes[i].NomePaciente);
            }

            Console.WriteLine("-----------------------------");

        }

        public void ExcluirPaciente()
        {

            ListarPaciente();

            Console.WriteLine("\nDigite o ID do paciente que deseja excluir");
            int IdPaciente = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < Pacientes.Count; j++)
            {
                if (j == IdPaciente)
                {
                    Console.WriteLine("\n----Paciente a Ser Excluido----");
                    Console.WriteLine("Nome: " + Pacientes[j].NomePaciente);
                    Console.WriteLine("Idade: " + Pacientes[j].IdadePaciente);
                    Console.WriteLine("CPF: " + Pacientes[j].CpfPaciente);
                    Console.WriteLine("Altura: " + Pacientes[j].AlturaPaciente);
                    Console.WriteLine("Peso: " + Pacientes[j].PesoPaciente);
                    Console.WriteLine("-------------------------------\n");
                    Console.WriteLine("Você realmente deseja excluir o paciente:");
                    Console.WriteLine("1 - Sim\n2 - Não");

                    int excluirPaciente = Convert.ToInt32(Console.ReadLine());

                    if (excluirPaciente != 1)
                    {
                        Console.WriteLine("\nNenhum Paciente Excluido\n");
                    }
                    else
                    {
                        Pacientes.RemoveAt(j);
                    }

                }
            }

        }

    }
}
