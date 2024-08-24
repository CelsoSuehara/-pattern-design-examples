using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products;

public class PizzaMussarela : Pizza
{
    public PizzaMussarela() : base(TipoMassa.Pizza, "Pizza de Mussarela")
    {
        Ingredientes.Add("Queijo mussarela gratinado");
    }
}