using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTP
{
    class entradainformation
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private int produto_codigo;

        public int Produto_codigo
        {
            get { return produto_codigo; }
            set { produto_codigo = value; }
        }

        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }

        }
    }
}
