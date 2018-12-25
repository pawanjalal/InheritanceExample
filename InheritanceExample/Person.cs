using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Person
    {
        // fields med variabler
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string CprNummer { get; set; }
        protected int InternId { get; set; }

        //constructor med 3 parametere
        public Person(string fornavn, string efternavn, int internId)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.InternId = internId;
        }

        public virtual void Kendetegn()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " " + InternId);
        }
    }
}
