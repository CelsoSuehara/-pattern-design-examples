using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products;

public abstract class Pizza : MassaBase
{
    public Pizza(TipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
    {
    }
}
