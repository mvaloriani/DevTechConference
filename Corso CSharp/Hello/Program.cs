using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona =
            //    new Persona("Matteo", "Valoriani", "mvaloriani@gmail.com");

            Studente studente = new Studente("Alessandro",
                "Pozone", 1213213);
            StudenteMagistrale ms = new StudenteMagistrale("xxx", "yyy", 12121, "110L", "acaso@fff.dd");

            persona.Cognome = "Valeriani";

            List<Persona> lista = new List<Persona>();

            lista.Add(new Studente("mm", "cc",1));
            lista.Add(new Studente("mc", "cc",2));
            lista.Add(new Studente("dssdmm", "ccwww",3));
            lista.Add(new Studente("fdsfds", "ccrrr",4));

            var temp = lista.Where(x => x.Cognome == "cc").ToList();


            //Console.WriteLine("Ciao Mondo, " +
            // persona.ChiSei());

            Console.WriteLine("Ciao Mondo, " +
             ((Persona)studente).ChiSei());
            Console.WriteLine("Ciao Mondo, " +
             ((Studente)ms).ChiSei());
            Console.Read();
        }
    }
}
