namespace FactoryMethod;

public abstract class PizzaFactoryMethod
{
    public Pizza MontaPizza(string tipo)
    {
        Pizza pizza;
        pizza = CriaPizza(tipo);
        return pizza;
    }

    protected abstract Pizza CriaPizza(string tipo);
}
