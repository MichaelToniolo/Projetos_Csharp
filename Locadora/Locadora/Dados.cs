using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora
{
   public class Dados
    {
       public static string StringDeConexao
       {
           get
           {
               //Endereço da string de conexão

               return @"server=SARAIVA-PC\SQLEXPRESS; database = Locadora; Trusted_Connection = true";

           }
 
       }
    }
}
