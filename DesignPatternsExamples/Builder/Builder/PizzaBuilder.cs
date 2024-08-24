﻿using Builder.Product;

namespace Builder.Builder;

public abstract class PizzaBuilder
{
    protected Pizza pizza;

    public void CriaPizza()
    {
        pizza = new Pizza();
    }

    public Pizza GetPizza() { return pizza; }

    public abstract void PreparaPizza();

    public abstract void IncluiIngredientes();
}
