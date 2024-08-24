using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products;

public sealed class BoloChocolate : Bolo
{
    public BoloChocolate() : base(TipoMassa.Bolo, "Bolo de Chocolate")
    {
        Ingredientes.Add("Com cobertura de chocolate");
    }
}
