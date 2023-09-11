using ExemploHeranca___01.classes;
using ExemploHeranca___01.classes2;

public class Program
{ 
    static void Main(string[] args)
    {
        Aluno a = new Aluno();
        a.Cpf = "00";
        a.Nome = "Joao da silva";
        a.DataNasc = DateOnly.Parse("20-09-2020");
        a.Responsavel = "Maria";

        Funcionario f = new Funcionario();
        f.Cpf = "111";
        f.Nome = "Elias";

        Cachorro c = new Cachorro();
        c.Raca = "Vira-Lata";
        c.Barulho();

        Gato g = new Gato();
        g.Raca = "Chatonildo";
        g.Barulho();
    }

}

