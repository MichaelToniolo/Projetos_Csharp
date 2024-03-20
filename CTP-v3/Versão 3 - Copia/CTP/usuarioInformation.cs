using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTP
{
    class usuarioInformation
    {
        private int usu_cod;

        public int usu_Cod
        {
            get { return usu_cod; }
            set { usu_cod = value; }
        }

        private string usu_nome;

        public string usu_Nome
        {
            get { return usu_nome; }
            set { usu_nome = value; }
        }
        private string usu_senha;

        public string usu_Senha
        {
            get { return usu_senha; }
            set { usu_senha = value; }
        }
    }
}
