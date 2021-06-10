using System;
using projeto_produtos.Interfaces;
namespace projeto_produtos.Classes
{
    public class Users
    {
        private int codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private DateTime DataCadastro;

        public Users() { }

        public Users(int _codigo, string _Nome, string _Email, string _Senha)
        {
            codigo = _codigo;
            Nome = _Nome;
            Email = _Email;
            Senha = _Senha;
            DataCadastro = DateTime.Now;
        }


        public string CadastrarUser(Users users)
        {
            return "\nUsuario cadastrado com sucesso !";
        }

        public string DeletarUser(Users users)
        {

            Nome = "";
            Email = "";
            Senha = "";

            return "\nUsuario apagado";
        }
    }
}