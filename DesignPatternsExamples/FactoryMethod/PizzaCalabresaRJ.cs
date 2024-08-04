namespace FactoryMethod;

public class PizzaCalabresaRJ : Pizza
{
    public PizzaCalabresaRJ()
    {
        Nome = "Pizza de Calabresa Carioca com Cebola";
        Massa = "Massa tradicional carioca";
        Molho = "Molho de tomate italiano carioca";
        Ingredientes.Add("Fatias de calabresa especial");
        Ingredientes.Add("Queijo parmesão italiano tradicional");
    }
}
