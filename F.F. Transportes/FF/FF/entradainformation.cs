using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF
{
    class entradainformation
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int nf;

        public int Nf
        {
            get { return nf; }
            set { nf = value; }
        }
        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private string fornecedor;

        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private DateTime dataentrada;

        public DateTime Dataentrada
        {
            get { return dataentrada; }
            set { dataentrada = value; }
        }
        private int codifornecedor;

        public int Codifornecedor
        {
            get { return codifornecedor; }
            set { codifornecedor = value; }
        }
        private int baixacodigo;

        public int Baixacodigo
        {
            get { return baixacodigo; }
            set { baixacodigo = value; }
        }
        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        
    }
}
