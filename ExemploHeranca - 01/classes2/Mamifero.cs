using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca___01.classes2
{
    internal class Mamifero
    {
        public DateOnly DataNasc { get; set; }
        public string Raca { get; set; }
      

        public virtual void Barulho()
        {
            Console.WriteLine(this.Raca + "Fazendo Barulho");
        }
    }
}
