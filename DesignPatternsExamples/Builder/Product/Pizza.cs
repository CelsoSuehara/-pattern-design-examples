namespace Builder.Product;

public class Pizza
{
    public TipoMassa TipoMassa { get; set; }
    public TipoBorda TipoBorda { get; set; }
    public Tamanho Tamanho { get; set; }
    public List<string> Ingredientes { get; set; }

    public void PizzaConteudo()
    {
        Console.WriteLine($"Pizza com massa: {TipoMassa}");
        Console.WriteLine($"Tipo de borda: {TipoBorda}");
        Console.WriteLine($"Tamanho: {Tamanho}");
        Console.WriteLine("Ingredientes:");
        foreach (var integrediente in Ingredientes)
        {
            Console.WriteLine($"{integrediente}");
        }
        Console.WriteLine("\n\n");
    }
}
