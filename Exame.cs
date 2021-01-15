using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultorioMédico
{
    public sealed class Exame
    {

        private int CodigoExame { get; set; }
        private string NomePaciente { get; set; }
        private int CpfPaciente { get; set; }


        private static List<Exame> Exames = new List<Exame>();

        private static List<Exame> ExamesInativos = new List<Exame>();

        //Construtores
        public Exame(int codigoExame, string nomePaciente, int cpfPaciente)
        {
            this.CodigoExame = codigoExame;
            this.NomePaciente = nomePaciente;
            this.CpfPaciente = cpfPaciente;
        }

        //Metodos

        public void AtualizarExame()
        {
            Console.WriteLine("Como deseja buscar o exame para atualiza-lo?\n1 - Nome\n2 - Código Exame\n3 - CPF do Paciente");
            string tipoBusca = Console.ReadLine();

            //Switch Buscando o exame a ser atualizado
            switch (tipoBusca)
            {
                //Busca o exame pelo nome do paciente
                case "1":
                    Console.WriteLine("Digite o nome do paciente");
                    string nomePaciente = Convert.ToString(Console.ReadLine());
                    string nomePacienteUpper = nomePaciente.ToUpper();

                    for (int i = 0; i < Exames.Count; i++)
                    {
                        if (Exames[i].NomePaciente == nomePacienteUpper)
                        {

                            Console.WriteLine("O que deseja atualizar neste exame?\n1 - Código do Exame\n2 - Nome\n3 - CPF do Paciente");
                            string opcaoAtualizacao = Console.ReadLine();

                            //Switch com o dado a ser atualizado
                            switch (opcaoAtualizacao)
                            {
                                //Opção para atualizar o código do exame
                                case "1":
                                    Console.WriteLine("Qual o novo código do exame?");
                                    int novoCodigo = Convert.ToInt32(Console.ReadLine());
                                    Exames[i].CodigoExame = novoCodigo;
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                //Opção para atualizar o nome do paciente no exame
                                case "2":
                                    Console.WriteLine("Qual o novo nome do exame?");
                                    string novoNome = Console.ReadLine();
                                    Exames[i].NomePaciente = novoNome.ToUpper();
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                //Opção para atualizar o CPF do paciente no exame 
                                case "3":
                                    Console.WriteLine("Qual o novo CPF do exame?");
                                    int novoCpf = Convert.ToInt32(Console.ReadLine());
                                    Exames[i].CpfPaciente = novoCpf;
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;



                                default:
                                    Console.WriteLine("Opção Inválida");
                                    AtualizarExame();
                                    break;
                            }

                            //Caso não retorne nenhum dado 
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dado encontrado");
                        }

                    }
                    break;

                //Busca o exame pelo seu código
                case "2":
                    Console.WriteLine("Digite o codigo do exame do paciente");
                    int codigoExame = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < Exames.Count; i++)
                    {
                        if (Exames[i].CodigoExame == codigoExame)
                        {

                            Console.WriteLine("O que deseja atualizar neste exame?\n1 - Código do Exame\n2 - Nome\n3 - CPF do Paciente");
                            string opcaoAtualizacao = Console.ReadLine();

                            //Switch com o dado a ser atualizado
                            switch (opcaoAtualizacao)
                            {
                                //Opção para atualizar o código do exame
                                case "1":
                                    Console.WriteLine("Qual o novo código do exame?");
                                    int novoCodigo = Convert.ToInt32(Console.ReadLine());
                                    Exames[i].CodigoExame = novoCodigo;
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                //Opção para atualizar o nome do paciente no exame
                                case "2":
                                    Console.WriteLine("Qual o novo nome do exame?");
                                    string novoNome = Console.ReadLine();
                                    Exames[i].NomePaciente = novoNome.ToUpper();
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                //Opção para atualizar o CPF do paciente no exame
                                case "3":
                                    Console.WriteLine("Qual o novo CPF do exame?");
                                    int novoCpf = Convert.ToInt32(Console.ReadLine());
                                    Exames[i].CpfPaciente = novoCpf;
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                default:
                                    Console.WriteLine("Opção Inválida");
                                    AtualizarExame();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dado encontrado");
                        }
                    }
                    break;

                //Busca o exame pelo CPF do paciente
                case "3":
                    Console.WriteLine("Digite o CPF do paciente");
                    int cpfPaciente = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < Exames.Count; i++)
                    {
                        if (Exames[i].CpfPaciente == cpfPaciente)
                        {

                            Console.WriteLine("O que deseja atualizar neste exame?\n1 - Código do Exame\n2 - Nome\n3 - CPF do Paciente");
                            string opcaoAtualizacao = Console.ReadLine();

                            //Switch com o dado a ser atualizado
                            switch (opcaoAtualizacao)
                            {
                                //Opção para atualizar o código do exame 
                                case "1":
                                    Console.WriteLine("Qual o novo código do exame?");
                                    int novoCodigo = Convert.ToInt32(Console.ReadLine());
                                    Exames[i].CodigoExame = novoCodigo;
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                //Opção para atualizar o nome no exame
                                case "2":
                                    Console.WriteLine("Qual o novo nome do exame?");
                                    string novoNome = Console.ReadLine();
                                    Exames[i].NomePaciente = novoNome.ToUpper();
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;

                                //Opção para atualizar o CPF no exame
                                case "3":
                                    Console.WriteLine("Qual o novo CPF do exame?");
                                    int novoCpf = Convert.ToInt32(Console.ReadLine());
                                    Exames[i].CpfPaciente = novoCpf;
                                    Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    AtualizarExame();
                                    break;
                            }


                        }
                        else
                        {

                        }

                    }
                    break;


                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }




        public void VisualizarExame()
        {
            Console.WriteLine("Como deseja fazer a busca de exame para visualiza-lo?\n1 - Nome\n2 - Código do Exame\n3- CPF do Paciente ");
            string tipoBusca = Console.ReadLine();

            //Tipo de busca do exame para visualiza-lo
            switch (tipoBusca)
            {
                //Busca pelo nome do paciente
                case "1":

                    Console.WriteLine("Digite o nome do paciente que está no exame");
                    string nomePaciente = Convert.ToString(Console.ReadLine());
                    string nomePacienteUpper = nomePaciente.ToUpper();

                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].NomePaciente == nomePacienteUpper)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                        }
                    }
                    break;

                //Busca pelo código do exame do paciente
                case "2":

                    Console.WriteLine("Digite o código do exame");
                    int codigoExame = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].CodigoExame == codigoExame)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                        }
                    }

                    break;

                //Busca pelo CPF do paciente
                case "3":

                    Console.WriteLine("Digite o CPF do paciente que está no exame");
                    int cpfPaciente = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].CpfPaciente == cpfPaciente)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                        }
                    }

                    break;


                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
        public void InativarExame()
        {
            Console.WriteLine("Como deseja buscar o exame para inativa-lo?\n1 - Nome\n2 - Código do Exame\n3- CPF do Paciente ");
            string tipoBusca = Console.ReadLine();

            //Opção de busca para inativar o exame
            switch (tipoBusca)
            {
                //Busca pelo nome do paciente
                case "1":

                    Console.WriteLine("Digite o nome do paciente que está no exame");
                    string nomePaciente = Convert.ToString(Console.ReadLine());
                    string nomePacienteUpper = nomePaciente.ToUpper();

                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].NomePaciente == nomePacienteUpper)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                            Console.WriteLine("Você realmete deseja inativar este exame?\n1 - Sim\n2 - Não");
                            int inativarExame = Convert.ToInt32(Console.ReadLine());

                            if (inativarExame != 1)
                            {
                                Console.WriteLine("Nenhum Exame Inativado");
                            }
                            else
                            {
                                ExamesInativos.Add(Exames[j]);
                                Exames.RemoveAt(j);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dado encontrado");
                        }
                    }
                    break;

                //Busca pelo código do exame do paciente
                case "2":

                    Console.WriteLine("Digite o código do exame");
                    int codigoExame = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].CodigoExame == codigoExame)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                            Console.WriteLine("Você realmete deseja inativar este exame?\n1 - Sim\n2 - Não");
                            int inativarExame = Convert.ToInt32(Console.ReadLine());

                            if (inativarExame != 1)
                            {
                                Console.WriteLine("Nenhum Exame Inativado");
                            }
                            else
                            {
                                ExamesInativos.Add(Exames[j]);
                                Exames.RemoveAt(j);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dado não encontrado");
                            AtualizarExame();
                        }
                    }

                    break;

                //Busca pelo CPF do paciente
                case "3":

                    Console.WriteLine("Digite o CPF do paciente que está no exame");
                    int cpfPaciente = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].CpfPaciente == cpfPaciente)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                            Console.WriteLine("Você realmete deseja inativar este exame?\n1 - Sim\n2 - Não");
                            int inativarExame = Convert.ToInt32(Console.ReadLine());

                            if (inativarExame != 1)
                            {
                                Console.WriteLine("Nenhum Exame Inativado");
                            }
                            else
                            {
                                ExamesInativos.Add(Exames[j]);
                                Exames.RemoveAt(j);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dado não encontrado");
                            AtualizarExame();
                        }
                    }

                    break;


                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }


        }
        public void ListarExamesInativos()
        {

            for (int i = 0; i < ExamesInativos.Count; i++)
            {
                Console.WriteLine("Código/Nome/CPF\n");
                Console.WriteLine(ExamesInativos[i].CodigoExame + "-" + ExamesInativos[i].NomePaciente + "-" + ExamesInativos[i].CpfPaciente + "\n");
            }

        }

        public void BuscarExame()
        {
            Console.WriteLine("Como deseja fazer a busca de exame?\n1 - Nome\n2 - Código do Exame\n3- CPF do Paciente ");
            string tipoBusca = Console.ReadLine();

            //Switch com a opção de busca
            switch (tipoBusca)
            {
                //Busca por nome
                case "1":

                    Console.WriteLine("Digite o nome do paciente que está no exame");
                    string nomePaciente = Convert.ToString(Console.ReadLine());
                    string nomePacienteUpper = nomePaciente.ToUpper();

                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].NomePaciente == nomePacienteUpper)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                        }
                    }
                    break;

                //Busca pelo código do exame
                case "2":

                    Console.WriteLine("Digite o código do exame");
                    int codigoExame = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].CodigoExame == codigoExame)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                        }
                    }

                    break;

                //Busca pelo CPF do paciente 
                case "3":

                    Console.WriteLine("Digite o CPF do paciente que está no exame");
                    int cpfPaciente = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\n--Resultado da Busca--");

                    for (int j = 0; j < Exames.Count; j++)
                    {
                        if (Exames[j].CpfPaciente == cpfPaciente)
                        {
                            Console.WriteLine("Código/Nome/CPF\n");
                            Console.WriteLine(Exames[j].CodigoExame + "-" + Exames[j].NomePaciente + "-" + Exames[j].CpfPaciente + "\n");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }


        }
        public void CadastrarExame()
        {
            Console.WriteLine("Digite o código do exame");
            int codigoExame = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do paciente");
            string nomePaciente = Convert.ToString(Console.ReadLine());
            string nomePacienteUpper = nomePaciente.ToUpper();

            Console.WriteLine("Digite o CPF do paciente");
            int cpfPaciente = Convert.ToInt32(Console.ReadLine());

            Exame exame = new Exame(codigoExame, nomePacienteUpper, cpfPaciente);

            Exames.Add(exame);

            Console.WriteLine("Deseja Realizar Mais um exame?\n1 - Sim\n2 - Não");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha != 1)
            {
                Console.WriteLine("\nExame(s) Realizado(s) com Sucesso\n");
            }
            else
            {
                CadastrarExame();
            }
        }
        public void ListarExames()
        {

            Console.WriteLine("----Lista de Exames---");
            Console.WriteLine("Código/Nome/CPF\n");
            for (int i = 0; i < Exames.Count; i++)
            {
                Console.WriteLine(Exames[i].CodigoExame + "-" + Exames[i].NomePaciente + "-" + Exames[i].CpfPaciente + "\n");

            }
        }
    }
}
