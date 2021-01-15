//Program

using System;

namespace ConsultorioMédico
{
    class Program
    {


        static void Main(string[] args)
        {
            bool saidaSistema = true;

            while (saidaSistema == true)
            {
                Paciente paciente = new Paciente("", 0, 0, 0, 0);
                Exame exame = new Exame(0, "", 0);


                Console.WriteLine("\nO que deseja fazer?\n");
                Console.WriteLine("\n------Exame-----\n");
                Console.WriteLine("1 - Listar Exame");
                Console.WriteLine("2 - Atualizar Exame");
                Console.WriteLine("3 - Visualizar Exame");
                Console.WriteLine("4 - Inativar Exame");
                Console.WriteLine("5 - Buscar Exame");
                Console.WriteLine("6 - Cadastrar Exame");
                Console.WriteLine("7 - Listar Exames Inativos");
                Console.WriteLine("\n------Paciente-----\n");
                Console.WriteLine("8 - Cadastrar Paciente");
                Console.WriteLine("9 - Listar Pacientes");
                Console.WriteLine("10 - Excluir Paciente");
                Console.WriteLine("\n------------------\n");
                Console.WriteLine("11 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        exame.ListarExames();
                        break;

                    case "2":

                        exame.AtualizarExame();
                        break;

                    case "3":
                        exame.VisualizarExame();
                        break;

                    case "4":
                        exame.InativarExame();
                        break;

                    case "5":
                        exame.BuscarExame();
                        break;

                    case "6":
                        exame.CadastrarExame();
                        break;

                    case "7":
                        exame.ListarExamesInativos();
                        break;
                    case "8":
                        paciente.CadastrarPaciente();
                        break;

                    case "9":
                        paciente.ListarPaciente();
                        break;

                    case "10":
                        paciente.ExcluirPaciente();
                        break;

                    case "11":
                        Console.WriteLine("\nVocê realmente deseja sair?\n1 - Sim\n2 - Não");
                        int sair = Convert.ToInt32(Console.ReadLine());

                        if (sair != 1) { }
                        else
                        {
                            saidaSistema = false;
                            Console.WriteLine("\nFora do sistema");
                        }

                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }
    }
}
