using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTP
{
    class ProdutoInformation
    {
        private int pr_codigo;

        public int Pr_codigo
        {
            get { return pr_codigo; }
            set { pr_codigo = value; }
        }

        private string pr_descricao;

        public string Pr_descricao
        {
            get { return pr_descricao; }
            set { pr_descricao = value; }
        }

        private int pr_quantidade;

        public int Pr_quantidade
        {
            get { return pr_quantidade; }
            set { pr_quantidade = value; }
        }

        private string pr_marca;

        public string Pr_marca
        {
            get { return pr_marca; }
            set { pr_marca = value; }
        }

        private DateTime pr_datacad;

        public DateTime Pr_datacad
        {
            get { return pr_datacad; }
            set { pr_datacad = value; }
        }

        private string pr_fornecedor;

        public string Pr_fornecedor
        {
            get { return pr_fornecedor; }
            set { pr_fornecedor = value; }
        }

        private decimal pr_preco;

        public decimal Pr_preco
        {
            get { return pr_preco; }
            set { pr_preco = value; }
        }

        private int pr_usu_codigo;

        public int Pr_usu_codigo
        {
            get { return pr_usu_codigo; }
            set { pr_usu_codigo = value; }
        }
        
        
    }
}
