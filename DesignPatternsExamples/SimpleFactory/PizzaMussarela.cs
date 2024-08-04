using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;

public class PizzaMussarela : Pizza
{
    public PizzaMussarela()
    {
        Nome = "Pizza de Mussarela";
    }

    public override void Assar(int tempo)
    {
        Console.WriteLine($"{this.Nome} assando por {tempo} min.");
    }

    public override void Embalar()
    {
        Console.WriteLine($"Embalando a {Nome}");
    }

    public override void Preparar()
    {
        Console.WriteLine($"Preparando a {Nome}");
    }
}
