using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class StudenteMagistrale : Studente
    {
        public string voto;




        public StudenteMagistrale(string nome, string cognome, int matricola, string voto, string email) :
            base(nome, nome, matricola, email) { this.voto = voto; }
    }
}
