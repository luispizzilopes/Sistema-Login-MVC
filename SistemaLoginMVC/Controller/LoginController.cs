using SistemaLoginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginMVC.Controller
{
    internal class LoginController
    {
        LoginModel login = new LoginModel();

        public bool Acessar(string usuario, string senha)
        {
            if(login.Acessar(usuario, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            if(login.Cadastrar(usuario, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
