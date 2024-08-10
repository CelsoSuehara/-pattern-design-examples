using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products;

public class PizzaCalabresa : Pizza
{
    public PizzaCalabresa() : base(TipoMassa.Pizza, "Pizza de Calabresa")
    {
        Ingredientes.Add("Calabresa fatiada");
        Ingredientes.Add("cebola fatiada");
    }
}
