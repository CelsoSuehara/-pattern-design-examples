using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory;

public sealed class BoloFactory : MassasAbstractFactory
{
    public override MassaBase CriaMassa(TipoMassa tipoMassa)
    {
        var tipoBolo = (TipoBolo)tipoMassa;

        switch (tipoBolo)
        {
            case TipoBolo.Chocolate:
                return new BoloChocolate();
            case TipoBolo.Laranja:
                return new BoloLaranja();
            default:
                throw new ArgumentOutOfRangeException("Tipo não implementado.");
        }
    }
}
