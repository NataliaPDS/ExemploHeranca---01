using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca___01.classes
{
    internal class Funcionario:Pessoa
    {
        public double Salario { get; set; }
        public string SIAP { get; set; }
        public int CargaHoraria { get; set; }
    }
}
