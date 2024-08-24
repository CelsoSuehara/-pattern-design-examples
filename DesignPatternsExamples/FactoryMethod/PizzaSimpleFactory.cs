namespace FactoryMethod;

public class PizzaSimpleFactory
{
    public static PizzaFactoryMethod CriaPizzaria(string local)
    {
        PizzaFactoryMethod pizzaria;

        switch (local)
        {
            case "SP":
                pizzaria = new PizzaFactorySP();
                break;
            case "RJ":
                pizzaria = new PizzaFactoryRJ();
                break;
            default:
                throw new ArgumentException($"O local {local} não foi localizado.");
        }

        return pizzaria;
    }
}
