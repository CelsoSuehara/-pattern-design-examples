namespace SimpleFactory;

public class PizzaCalabresa : Pizza
{
    public PizzaCalabresa()
    {
        Nome = "Pizza de Calabresa";
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
