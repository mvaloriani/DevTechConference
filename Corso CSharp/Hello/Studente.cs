using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Studente : Persona
    {
        public int matricola;

        public Studente(string nome, string cognome, int matricola,
            string email = "pincopallo@polimi.it"
           ): base(nome, cognome, email)
        {
            this.matricola = matricola;

            
        }

        public override string Biglietto
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public new string ChiSei()
        {
            return base.ChiSei() + " la mia matricola e' " + matricola;
        }

        public override void CompraBiglietto(string origine, string destinazione)
        {
            throw new NotImplementedException();
        }
    }
}
