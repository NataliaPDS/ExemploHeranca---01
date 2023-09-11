using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca___01.classes2
{
    internal class Gato:Mamifero
    {
        public string CorDeOlho {  get; set; }

        public override void Barulho()
        {
            Console.WriteLine("Miauuuu!");
        }
    }
}
