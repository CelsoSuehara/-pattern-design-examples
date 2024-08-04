namespace FactoryMethod;

public class PizzaMussarelaSP : Pizza
{
    public PizzaMussarelaSP()
    {
        Nome = "Pizza de Mussarela Paulista";
        Massa = "Massa fina e crocante paulista";
        Molho = "Molho de tomate italiano paulista";
        Ingredientes.Add("Queijo Parmesão");
        Ingredientes.Add("Azeitonas verdes");
    }
}
