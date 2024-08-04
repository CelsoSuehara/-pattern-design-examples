namespace FactoryMethod;

public class PizzaCalabresaSP : Pizza
{
    public PizzaCalabresaSP()
    {
        Nome = "Pizza de Calabresa Paulista";
        Massa = "Massa fina e crocante paulista";
        Molho = "Molho de tomate italiano paulista";
        Ingredientes.Add("Fatias de calabresa defumada especial");
        Ingredientes.Add("Queijo parmesão italiano tradicional");
    }
}
