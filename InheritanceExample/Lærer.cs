using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Lærer : Person
    {
        protected int Bankkonto { get; set; }

        //Constructor som aver fra parent constructoreren i Person klassen
        public Lærer(string fornavn, string efternavn, int internId, int bankkonto)
            : base(fornavn, efternavn, internId)
        {
            this.Bankkonto = bankkonto;
        }

        //Method
        public override void Kendetegn()
        {
            Console.WriteLine("Fornavn: " + Fornavn + "\n" 
                            + "Efternavn: " + Efternavn + "\n" 
                            + "Lærerens ID: " + InternId + "\n" 
                            + "Lærerens bank konto: " + Bankkonto);
        }
    }
}
