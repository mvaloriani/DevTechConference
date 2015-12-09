using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public abstract class  Persona : IPersona, IViaggiatore
    {
        protected string nome;
        public String Nome
        {
            get { return nome; }
        }


        private string cognome;
        public String Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public abstract string Biglietto { get; set; }

        private string email;


        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public Persona(string nome, string cognome, string email = "")
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
        }

        public virtual string ChiSei()
        {
            return "Io sono " + Nome + " " + Cognome; 
        }

        public abstract void CompraBiglietto(string origine, string destinazione);

        //public Persona(string nome, string cognome) : 
        //    this(nome,cognome, "")
        //{         
        //}

    }
}
