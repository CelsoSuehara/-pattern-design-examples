using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder;

public sealed class PizzaCalabresa : PizzaBuilder
{
    public override void PreparaPizza()
    {
        pizza.TipoMassa = TipoMassa.Grossa;
        pizza.TipoBorda = TipoBorda.Normal;
        pizza.Tamanho = Tamanho.Grande;
    }

    public override void IncluiIngredientes()
    {
        pizza.Ingredientes = new List<string> { "Calabresa fatiada", "Molho de tomate" };
    }
}
