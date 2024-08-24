namespace FactoryMethod;

public class PizzaMussarelaRJ : Pizza
{
    public PizzaMussarelaRJ()
    {
        Nome = "Pizza de Mussarela Carioca";
        Massa = "Massa tradicional carioca";
        Molho = "Molho de tomate italiano carioca";
        Ingredientes.Add("Queijo Parmesão Ralado");
        Ingredientes.Add("Azeitonas pretas");
    }
}
