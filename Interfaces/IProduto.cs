using System.Collections.Generic;
using projeto_produtos.Classes;
namespace projeto_produtos.Interfaces
{
    public interface IProduto
    {
        string Cadastrar(Produto produto);
        List<Produto> ListarP();

        string Deletar(Produto produto, int index);
    }
}