using System.Collections.Generic;
using System;
using projeto_produtos.Interfaces;

namespace projeto_produtos.Classes
{
    public class Marca : IMarca
    {
        // variáveis
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        private DateTime DataCadastro = DateTime.Now;

        public List<Marca> Marcas = new List<Marca>();

        List<Marca> marcas1 = new List<Marca>();


        public string Cadastrar(Marca novaMarca)
        {

            Marcas.Add(novaMarca);
            return "\nA marca foi registrada com sucesso !";

            // funcionando
        }

        public List<Marca> Listar()
        {
            foreach (Marca item in Marcas)
            {
                int i = 1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n=================================");
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($@"Nome da marca: {item.NomeMarca}                  {i}° Produto     ");
                Console.WriteLine(item.DataCadastro);
                Console.ResetColor();
                i++;
            }

            // funcionando

            return Marcas;
        }

        public string Deletar(Marca marca, int index)
        {

            Marcas.RemoveAt(index);


            return "\nMarca removida com sucesso";

            // funcionando
        }

    }
}