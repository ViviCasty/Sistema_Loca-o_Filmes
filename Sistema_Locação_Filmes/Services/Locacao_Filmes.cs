
using Sistema_Locação_Filmes.Models;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Sistema_Locação_Filmes.Services
{
    class Locadora
    {

        private List<Filmes> filmes = new List<Filmes>();
        private List<Clientes> clientes = new List<Clientes>();
        private List<Locacao> locacoes = new List<Locacao>();

        private int idFilme = 0;
        private int idCliente = 0;
        private int idLocacao = 0;
        public void MenuPrincipal()
        {
            while (true)
            {
                Console.WriteLine("================ MENU PRINCIPAL ====================");
                Console.WriteLine();
                Console.WriteLine("Escolha qualquer uma dessas opções");
                Console.WriteLine("1 - Gerenciar Filmes");
                Console.WriteLine("2 - Gerenciar Clientes");
                Console.WriteLine("3 - Gerenciar Locações");
                Console.WriteLine("0 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        GerenciarFilmes();
                        break;
                    case 2:
                        GerenciarClientes();
                        break;
                    case 3:
                        GerenciarLocacoes();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }


            }

        }

        private void GerenciarFilmes()
        {
            while (true)
            {
                Console.WriteLine("================ MENU FILMES ====================");
                Console.WriteLine();
                Console.WriteLine("Escolha qualquer uma dessas opções");
                Console.WriteLine("1 - Adicionar Filmes");
                Console.WriteLine("2 - Deletar Filmes");
                Console.WriteLine("3 - Editar Filmes");
                Console.WriteLine("4 - Listar Filmes");
                Console.WriteLine("0 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarFilme();
                        break;
                    case 2:

                        DeletarFilme();
                        break;
                    case 3:

                        EditarFilme();
                        break;
                    case 4:

                        ListarFilme();
                        break;
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }
            }

        }

        private void GerenciarClientes()
        {
            while (true)
            {
                Console.WriteLine("================ MENU CLIENTES ====================");
                Console.WriteLine();
                Console.WriteLine("Escolha qualquer uma dessas opções");
                Console.WriteLine("1 - Adicionar Clientes");
                Console.WriteLine("2 - Deletar Clientes");
                Console.WriteLine("3 - Editar Clientes");
                Console.WriteLine("4 - Listar Clientes");
                Console.WriteLine("0 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        AdicionarCliente();
                        break;
                    case 2:

                        DeletarCliente();
                        break;
                    case 3:

                        EditarCliente();
                        break;
                    case 4:

                        ListarCliente();
                        break;
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }
            }
        }

        private void GerenciarLocacoes()
        {
            while (true)
            {
                Console.WriteLine("Menu de Locações");
                Console.WriteLine("Escolha qualquer uma dessas opções");
                Console.WriteLine("1 - Adicionar Locação");
                Console.WriteLine("2 - Devolução");
                Console.WriteLine("3 - Listar Locações");
                Console.WriteLine("0 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                //switch (opcao)
                //{
                //    case 1:
                //        Console.WriteLine("Adicionando Locação...");
                //        AdicionarLocação();
                //        break;
                //    case 2:
                //        Console.WriteLine("Devolução...");
                //        Devolucao();
                //        break;
                //    case 3:
                //        Console.WriteLine("Listando Locações...");
                //        ListarLocacoes();
                //        break;
                //    case 0:
                //        Console.WriteLine("Voltando ao menu principal...");
                //        return;
                //    default:
                //        Console.WriteLine("Opção inválida. Tente novamente.");
                //        break;

                //}
            }
        }


        // Métodos dos filmes

        private void AdicionarFilme()
        {
            Console.Write("Digite o nome do filme: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o gênero do filme: ");
            string genero = Console.ReadLine();

            var filme = new Filmes()
            {
                Id = idFilme + 1,
                Titulo = nome,
                Genero = genero
            };

            filmes.Add(filme);

            Console.WriteLine("Filme adicionado!");


        }

        private void DeletarFilme()
        {
            Console.Write("Digite o Id do filme que deseja deletar: ");

            int id = Convert.ToInt32(Console.ReadLine());

            var filme = filmes.FirstOrDefault(f => f.Id == id);

            if (filme != null)
            {
                filmes.Remove(filme);
                Console.WriteLine("Filme deletado!");

            }

            else
            {
                Console.WriteLine("Filme não encontrado!");
            }

        }

        private void EditarFilme()
        {
            Console.Write("Digite o Id do filme que deseja editar: ");

            int id = Convert.ToInt32(Console.ReadLine());

            var filme = filmes.FirstOrDefault(f => f.Id == id);

            if (filme != null)
            {
                Console.WriteLine("Digite o novo Título");
                string titulo = Console.ReadLine();
                filme.Titulo = titulo;
                Console.WriteLine("Digite o novo Gênero");
                string genero = Console.ReadLine();
                filme.Genero = genero;

                Console.WriteLine("Filme editado!");
            }

            else
            {
                Console.WriteLine("Filme não encontrado!");
            }

        }

        private void ListarFilme()
        {
            Console.WriteLine("Lista de Filmes:");
            foreach (var filme in filmes)
            {
                Console.WriteLine($"ID: {filme.Id} | Título: {filme.Titulo} | Gênero : {filme.Genero}");
            }
        }

        // Métodos dos clientes

        private void AdicionarCliente()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do cliente: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            var cliente = new Clientes()
            {
                Id = idCliente + 1,
                Nome = nome,
                Cpf = cpf,
                Idade = idade
            };

            clientes.Add(cliente);

            Console.WriteLine("Cliente adicionado!");


        }

        private void DeletarCliente()
        {
            Console.Write("Digite o Id do Cliente que deseja deletar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente removido");

            }

            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }

        }

        private void EditarCliente()
        {
            Console.Write("Digite o Id do cliente: ");

            int id = Convert.ToInt32(Console.ReadLine());

            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente != null)

            {
                Console.WriteLine("Cliente ENCONTRADO! ");

                Console.Write("Digite o novo nome do cliente: ");

                string nome = Console.ReadLine();

                Console.Write("Digite a nova idade do cliente: ");

                int idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo CPF do cliente: ");

                string cpf = Console.ReadLine();

                cliente.Nome = nome;
                cliente.Idade = idade;
                cliente.Cpf = cpf;


            }



        }

        private void ListarCliente()
        {
            Console.WriteLine();

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id} | Nome: {cliente.Nome} | Idade: {cliente.Idade} | CPF: {cliente.Cpf}");
            }
        }
    }

}

// validar cpf
// idade 18 n pode alugar filme de terror ou p
// validar se o cliente tem locação em aberto



