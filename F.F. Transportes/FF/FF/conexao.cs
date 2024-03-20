using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF
{
    class conexao
    {
        public static string conexaoBancoDados
        {
            get
            {
                // endereço da conexão
                //return @"server=MICHAEL-PC\MICHAELSARAIVA; database = fabio; Trusted_Connection = true";
                //return @"Server=FAGNER-PC\C:\; Database=CTP ;User Id =CTP; Password=122530; Trusted_Connection=true";
                return @"server=FAGNER-PC; database = fabio; Trusted_Connection = true";
            }
        }
    }
}
