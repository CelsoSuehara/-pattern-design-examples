namespace SimpleFactory;

public class Pizzaria
{
    public static void SolicitaPizza()
    {
		Console.WriteLine(" === Pizzaria ===");
		Console.WriteLine("Informe a Pizza (C)alabresa ou (M)ussarela \n");

        var tipo = Console.ReadLine().ToUpper();
		try
		{
			Pizza pizza = PizzaSimpleFactory.CriaPizza(tipo);
			pizza.Preparar();
			pizza.Assar(10);
			pizza.Embalar();
			Console.WriteLine("Pizza Concluída!");

		}
		catch (Exception ex)
		{
			Console.WriteLine($"Erro: {ex.Message}");
		}
    }
}
