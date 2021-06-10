using System;
using projeto_produtos.Classes;
namespace projeto_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Users users = new Users();

            login.Login1(users);
        }
    }
}
