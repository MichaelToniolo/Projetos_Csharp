using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
   public class Dados
    {
       public static string StringDeConexao
       {
           get
           {
               /*a sua conexão irá conseguir
                * com o botão direito na base de dados
                * em Server Explorer */
               return @"Data Source=SARAIVA-PC;Initial Catalog=agenda;Integrated Security=True;Pooling=False";

           }
       }
    }
}
