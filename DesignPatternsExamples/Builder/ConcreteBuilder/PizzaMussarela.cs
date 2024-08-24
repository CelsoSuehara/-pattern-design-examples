using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder;

public sealed class PizzaMussarela : PizzaBuilder
{
    public override void PreparaPizza()
    {
        pizza.TipoMassa = TipoMassa.Normal;
        pizza.TipoBorda = TipoBorda.Recheada;
        pizza.Tamanho = Tamanho.Grande;
    }

    public override void IncluiIngredientes()
    {
        pizza.Ingredientes = new List<string> { "Mussarela ralada", "Molho de tomate", "Orégano" };
    }
}
