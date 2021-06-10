using System.Collections.Generic;
using projeto_produtos.Interfaces;
using System;
namespace projeto_produtos.Classes
{
    public class Produto : Marca, IProduto
    {

        public string MarcaProd;
        public int _Codigo;

        public string NomeProduto;

        public float Preco;

        public DateTime DataCadastro = DateTime.Now;


        public int contador = 0;


        public string CadastradoPor;

        private List<Produto> ListaDeProdutos = new List<Produto>();

        public string Cadastrar(Produto novoProduto)
        {
            ListaDeProdutos.Add(novoProduto);
            contador++;
            return "\nProduto Cadastrado!";

        }

        public List<Produto> ListarP()
        {

            foreach (Produto item in ListaDeProdutos)
            {
                
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("=================================");
                Console.WriteLine($"Marca: {item.MarcaProd} ");
                Console.WriteLine($"Código: {item.Codigo} ");
                Console.WriteLine($@"Nome do Produto: {item.NomeProduto}              {item.contador}° Produto      ");
                Console.WriteLine($"Preço: {item.Preco:C2} ");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor} ");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro} ");
                Console.ResetColor();

            }
            return ListaDeProdutos;
        }

        public string Deletar(Produto produto, int index)
        {
            ListaDeProdutos.RemoveAt(index);

            return "\nProduto deletado com sucesso!";
        }

    }
}