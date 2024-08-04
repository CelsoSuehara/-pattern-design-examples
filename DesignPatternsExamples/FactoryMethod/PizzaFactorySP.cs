namespace FactoryMethod;

public class PizzaFactorySP : PizzaFactoryMethod
{
    protected override Pizza CriaPizza(string tipo)
    {
        switch (tipo)
        {
            case "M": 
                return new PizzaMussarelaSP();
            case "C":
                return new PizzaCalabresaSP();
            default:
                throw new ApplicationException("Opção inválida.");
        }
    }
}
