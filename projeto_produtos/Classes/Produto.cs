using System.Collections.Generic;
using projeto_produtos.Interfaces;
using System;
namespace projeto_produtos.Classes
{
    public class Produto : Marca,IProduto
    {

        public string MarcaProd;
        public int _Codigo;

        public string NomeProduto;

        public float Preco;

        private DateTime DataCadastro = DateTime.Now;


        public string CadastradoPor;

        private List<Produto> ListaDeProdutos = new List<Produto>();

        public string Cadastrar(Produto novoProduto)
        {
            ListaDeProdutos.Add(novoProduto);
            return "Produto Cadastrado!";
        }

        public List<Produto> ListarP()
        {

            foreach (Produto item in ListaDeProdutos)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("=================================");
                Console.WriteLine($"Marca: {item.MarcaProd} ");
                Console.WriteLine($"Código: {item.Codigo} ");
                Console.WriteLine($"Nome do Produto: {item.NomeProduto} ");
                Console.WriteLine($"Preço: {item.Preco:C2} ");
                Console.WriteLine($"Cadastrado por:{item.CadastradoPor} ");
                Console.ResetColor();
            }

            return ListaDeProdutos;
        }

        public string Deletar(Produto produto, int index)
        {
            ListaDeProdutos.RemoveAt(index);

            return "Produto deletado com sucesso!";
        }

    }
}