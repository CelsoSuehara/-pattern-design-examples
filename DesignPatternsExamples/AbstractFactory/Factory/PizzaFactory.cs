using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory;

public class PizzaFactory : MassasAbstractFactory
{
    public override MassaBase CriaMassa(TipoMassa tipoMassa)
    {
        var tipoPizza = (TipoPizza)tipoMassa;

        switch (tipoPizza)
        {
            case TipoPizza.Calabresa:
                return new PizzaCalabresa();
            case TipoPizza.Mussarela:
                return new PizzaMussarela();
            default:
                throw new ArgumentOutOfRangeException("Tipo não implementado.");
        }
    }
}
