namespace FactoryMethod;

public class PizzaFactoryRJ : PizzaFactoryMethod
{
    protected override Pizza CriaPizza(string tipo)
    {
        switch (tipo)
        {
            case "M":
                return new PizzaMussarelaRJ();
            case "C":
                return new PizzaCalabresaRJ();
            default:
                throw new ApplicationException("Opção inválida.");
        }
    }
}
