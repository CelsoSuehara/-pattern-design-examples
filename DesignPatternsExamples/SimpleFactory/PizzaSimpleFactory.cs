namespace SimpleFactory;

public sealed class PizzaSimpleFactory
{
    public static Pizza CriaPizza(string tipo)
    {
        Pizza pizza;

        switch (tipo)
        {
            case "M":
                pizza = new PizzaMussarela();
                break;
            case "C":
                pizza = new PizzaCalabresa();
                break;
            default:
                throw new ApplicationException($"A pizza do tipo {tipo} não existe.");
        }

        return pizza;
    }
}
