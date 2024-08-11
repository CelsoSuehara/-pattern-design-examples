namespace PrototypeShallowCopy.ConcretePrototype;

public class Soldado : ICloneable
{
    public string Nome { get; set; }
    public string Arma { get; set; }
    public Acessorio Acessorio { get; set; }

    public Soldado() { }

    public Soldado(Soldado soldado)
    {
        this.Nome = soldado.Nome;
        this.Arma = soldado.Arma;
        this.Acessorio = soldado.Acessorio;
    }

    public object Clone()
    {
        return new Soldado(this);
    }
}