using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora
{
   public class FilmeInformation
    {
        private int Fil_Codigo;

        public int fil_codigo
        {
            get { return Fil_Codigo; }
            set { Fil_Codigo = value; }
        }

        private int Fil_Duracao;

        public int fil_duracao
        {
            get { return Fil_Duracao; }
            set { Fil_Duracao = value; }
        }

        private int Fil_Estoque;

        public int fil_estoque
        {
            get { return Fil_Estoque; }
            set { Fil_Estoque = value; }
        }

        private string Fil_Nome;

        public string fil_nome
        {
            get { return Fil_Nome; }
            set { Fil_Nome = value; }
        }

        private decimal Fil_Vllocacao;

        public decimal fil_vllocacao
        {
            get { return Fil_Vllocacao; }
            set { Fil_Vllocacao = value; }
        }

        private string Fil_Sinopse;

        public string fil_sinopse
        {
            get { return Fil_Sinopse; }
            set { Fil_Sinopse = value; }
        }

        
    }
}
