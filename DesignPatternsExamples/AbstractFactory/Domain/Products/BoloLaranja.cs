using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products;

public sealed class BoloLaranja : Bolo
{
    public BoloLaranja() : base(TipoMassa.Bolo, "Bolo de Laranja")
    {
        Ingredientes.Add("Com cobertura de calda de laranja");
    }
}
