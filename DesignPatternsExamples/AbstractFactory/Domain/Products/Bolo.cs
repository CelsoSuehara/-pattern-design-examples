using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products;

public abstract class Bolo : MassaBase
{
    public Bolo(TipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
    {
    }
}
