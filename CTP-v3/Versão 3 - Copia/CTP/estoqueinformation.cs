using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTP
{
    class estoqueinformation
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
        private int baixa_codigo;

        public int Baixa_codigo
        {
            get { return baixa_codigo; }
            set { baixa_codigo = value; }
        }
        private string estoque_qtd;

        public string Estoque_qtd
        {
            get { return estoque_qtd; }
            set { estoque_qtd = value; }
        }

        private decimal preco;

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        private decimal totalbaixa;

        public decimal TotalBaixa
        {
            get { return totalbaixa; }
            set { totalbaixa = value; }
        }
        
        
    }
}
