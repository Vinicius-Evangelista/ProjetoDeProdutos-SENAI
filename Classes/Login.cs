using System;
using projeto_produtos.Interfaces;
using System.Collections.Generic;
namespace projeto_produtos.Classes
{
    public class Login : Produto, ILogin
    {
        public Users user1 = new Users();
        public string emailCad { get; set; }
        public string senha { get; set; }
        DateTime Datacadastro = DateTime.Now;

        bool Logado = true;

        public bool Menu = true;

        Marca marca = new Marca();
        Produto produto = new Produto();

        Produto novoProduto = new Produto();
        Marca marca1 = new Marca();
        Marca novaMarca = new Marca();
        public bool Online = false;

        public string Deslogar(Users users)
        {
            return "\nDeslogando...'";
        }

        public string Logar(Users users)
        {
            return "\nLogando ...";
        }

        public void Login1(Users users)
        {
            do
            {
                do
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"Você deseja se Cadastrar ou Fazer login?
                              ._________________________________________.
                              |=========================================|
                              | 1 - Cadastrar                           |
                              | 2 - Fazer Login                         |
                              | 3 - Sair                                |
                              |=========================================|");
                    string cadastro_login = Console.ReadLine();


                    switch (cadastro_login)
                    {
                        case "1":
                            Console.WriteLine("Digite seu Email");
                            user1.Email = Console.ReadLine();

                            Console.WriteLine("\nDigite seu Nome");
                            user1.Nome = Console.ReadLine();

                            Console.WriteLine("\nCrie sua Senha");
                            user1.Senha = Console.ReadLine();

                            Console.WriteLine("\nData do seu Cadastro: " + Datacadastro);

                            Console.WriteLine(users.CadastrarUser(user1));

                            break;

                        case "2":
                            Console.WriteLine("\nDigite o Email Cadastrado");
                            string emailLog = Console.ReadLine();

                            Console.WriteLine("\nDigite a senha Cadastrada");
                            string senhaLog = Console.ReadLine();

                            if (emailLog != user1.Email || senhaLog != user1.Senha)
                            {
                                Console.WriteLine("\nEmail ou Senha incorretos, digite novamente!");
                            }
                            else
                            {
                                Console.WriteLine(Logar(user1));
                                Menu = false;
                                Online = false;
                            }
                            break;

                        case "3":

                            Console.WriteLine("\nDeseja realmente fazer isso ? S/N");
                            string verificacao = Console.ReadLine().ToUpper();

                            if (verificacao == "S")
                            {
                                Logado = false;
                                Menu = false;
                                Online = true;
                            }
                            break;
                    }
                } while (Menu == true);


                while (Online == false)
                {
                    Console.WriteLine($@"
     .==========================.  
     | O que você deseja fazer? |
    '=========================='

.___________________________________.  
|===================================|
| 1 - Cadastrar Produto             |
| 2 - Cadastra Marca                |
| 3 - Deletar Produto               |
| 4 - Deletar Marca                 |
| 5 - Deletar Usuário               |
| 6 - Listar Marca                  |
| 7 - Listar Produto                | 
| 8 - Deslogar                      |
'==================================='
                                                ");
                    string optionsMN = Console.ReadLine();

                    List<Marca> marcaList = new List<Marca>();



                    switch (optionsMN)
                    {

                        case "1":

                            bool validacao = true;

                            while (validacao == true)
                            {
                                novoProduto = new Produto();

                                Console.WriteLine("\nQual o nome do produto?");
                                novoProduto.NomeProduto = Console.ReadLine();

                                Console.WriteLine("\nQual o preço do produto?");
                                novoProduto.Preco = float.Parse(Console.ReadLine());

                                Console.WriteLine("\nQual o código do seu produto?");
                                novoProduto.Codigo = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nA marca desejada ja foi cadastrada? S/N");
                                string respostaMarca = Console.ReadLine().ToUpper();

                                novoProduto.CadastradoPor = user1.Nome;



                                if (respostaMarca == "S")
                                {
                                    novaMarca.Listar();
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("\nQual a marca do seu Produto?");
                                    novoProduto.MarcaProd = Console.ReadLine();

                                    Console.WriteLine("\nDeseja cadastrar mais um produto ? S/N");
                                    string validacaoResposta = Console.ReadLine().ToUpper();


                                    if (validacaoResposta == "N")
                                    {
                                        validacao = false;
                                    }

                                }
                                else if (respostaMarca == "N")
                                {
                                    bool validaMarca = true;
                                    while (validaMarca == true)
                                    {


                                        Console.WriteLine("\nQual o nome da marca que você deseja cadastrar?");
                                        marca1.NomeMarca = Console.ReadLine();

                                        Console.WriteLine("\nQual o código da marca que você deseja cadastrar?");
                                        marca1.Codigo = int.Parse(Console.ReadLine());

                                        novaMarca.Listar();
                                        Console.ForegroundColor = ConsoleColor.Green;


                                        Console.WriteLine("\nDeseja cadastrar um novo produto? S/N");
                                        string resposta = Console.ReadLine().ToUpper();

                                        novaMarca.Cadastrar(marca1);

                                        novoProduto.MarcaProd = marca1.NomeMarca;


                                        if (resposta == "S")
                                        {
                                            validacao = true;
                                            validaMarca = false;
                                        }
                                        else if (resposta == "N")
                                        {
                                            validacao = false;

                                        }

                                    }
                                }
                                produto.Cadastrar(novoProduto);
                                // FUNCIONANDO GLÓRIA A DEUS    
                            }

                            break;

                        case "2":

                            bool menuMarca = true;
                            do
                            {
                                marca1 = new Marca();

                                Console.WriteLine("\nQual o nome da marca que você deseja cadastrar?");
                                marca1.NomeMarca = Console.ReadLine();

                                Console.WriteLine("\nQual o código da marca que você deseja cadastrar?");
                                marca1.Codigo = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nDeseja cadastrar uma nova marca? S/N");
                                string resposta = Console.ReadLine().ToUpper();

                                novaMarca.Cadastrar(marca1);

                                if (resposta == "S")
                                {
                                }
                                else if (resposta == "N")
                                {
                                    menuMarca = false;
                                }

                                // FUNCIONANDO GLÓRIA A DEUS    

                            } while (menuMarca == true);


                            break;

                        case "3":



                            produto.ListarP();

                            Console.WriteLine("\nDigite a posicão do produto que você deseja deletar");
                            int verficar = int.Parse(Console.ReadLine());

                            verficar = verficar - 1;

                            novoProduto.Deletar(produto, verficar);
                            break;


                        case "4":

                            novaMarca.Listar();

                            Console.WriteLine("\nDigite a posição do produto que você deseja deletar");

                            int verificar = int.Parse(Console.ReadLine());

                            novaMarca.Deletar(marca1, verificar);

                            break;


                        case "5":

                            Console.WriteLine("\nVocê tem certeza disso ? S/N");
                            string Apagar = Console.ReadLine().ToUpper();

                            if (Apagar == "S")
                            {
                                user1.Email = "";

                                user1.Nome = "";

                                user1.Senha = "";

                                Console.WriteLine(user1.DeletarUser(user1));

                                Online = true;
                                Menu = false;
                            }
                            else if (Apagar == "N")
                            {

                            }

                            break;

                        case "6":

                            novaMarca.Listar();
                            Console.ForegroundColor = ConsoleColor.Green;


                            break;

                        case "7":
            
                            produto.ListarP();
                            Console.ForegroundColor = ConsoleColor.Green;

                            break;

                        case "8":

                            Console.WriteLine("\nDeseja realmente deslogar ? S/N");
                            string verificacao = Console.ReadLine().ToUpper();

                            if (verificacao == "S")
                            {

                                Online = true;
                                Menu = false;


                            }
                            else if (verificacao == "N")
                            {

                            }

                            break;
                    }
                }
            } while (Logado == true);
        }
    }
}