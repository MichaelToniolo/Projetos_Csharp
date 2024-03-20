using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTP
{
    class Dados
    {
        public static string conexaoBancoDados
        {
            get
            {
                // endereço da conexão

                //return @"Server=192.168.0.96; Database=CTP; User Id =ADMIN-PC\Admin; Password=; Trusted_Connection=false";

                /*#region Conexão Servidor Levinne Modas
                //Conexão Servidor da Loja
                return @"server=ADMIN-PC\SQLEXPRESS; database = CTP2; Trusted_Connection = true";
                #endregion*/

                // FAGNER
                //return @"server=ADMIN-PC; database = CTP2; Trusted_Connection = true";

                //SAMUEL
                //return @"server=DESKTOP-7NP9IV8\SQLEXPRESS; database = CTP2; Trusted_Connection = true";
                return @"server=DESKTOP-33SFRIE\SQLEXPRESS; database = CTP2; Trusted_Connection = true";

                //return @"server=(LocalDB)\MSSQLLocalDB; database = C:\Users\CD\Desktop\Versão 1 0 0 9\Banco de Dados\CTP.mdf; Trusted_Connection = true";
            }
        }
    }
}
