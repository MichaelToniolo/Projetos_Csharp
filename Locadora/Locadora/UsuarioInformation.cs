using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora
{
   public class UsuarioInformation
    {
        private int Usu_Codigo;

        public int usu_codigo
        {
            get { return Usu_Codigo; }
            set { Usu_Codigo = value; }
        }

        private string Usu_Nome;

        public string usu_nome
        {
            get { return Usu_Nome; }
            set { Usu_Nome = value; }
        }

        private string Usu_Senha;

        public string usu_senha
        {
            get { return Usu_Senha; }
            set { Usu_Senha = value; }
        }



    }
}
