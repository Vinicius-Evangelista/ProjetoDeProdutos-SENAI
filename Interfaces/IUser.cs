using projeto_produtos.Classes;
namespace projeto_produtos.Interfaces
{
    public interface IUser
    {
        string CadastrarUser(Users users);
        string DeletarUser(Users users);
    }
}