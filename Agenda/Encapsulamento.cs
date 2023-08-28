using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    public class Encapsulamento
    {
        private int Age_id;

        public int age_id
        {
            get { return Age_id; }
            set { Age_id = value; }
        }

        private DateTime Age_dtnasc;

        public DateTime age_dtnasc
        {
            get { return Age_dtnasc; }
            set { Age_dtnasc = value; }
        }

        private string Age_nome;

        public string age_nome
        {
            get { return Age_nome; }
            set { Age_nome = value; }
        }

        private string Age_email;

        public string age_email    
        {
            get { return Age_email; }
            set { Age_email = value; }
        }

        private string Age_telcel;

        public string age_telcel
        {
            get { return Age_telcel; }
            set { Age_telcel = value; }
        }

        private string Age_telres;

        public string age_telres
        {
            get { return Age_telres; }
            set { Age_telres = value; }
        }

        private string Age_sexo;

        public string age_sexo
        {
            get { return Age_sexo; }
            set { Age_sexo = value; }
        }

        private string Age_uf;

        public string age_uf
        {
            get { return Age_uf; }
            set { Age_uf = value; }
        }
        
        
    }
}
