
using FactoryMethod;

Console.WriteLine("=== Pizzaria ===");

Console.WriteLine("Informe o local SP ou RJ");

var localEscolhido = Console.ReadLine().ToUpper();

Console.WriteLine("Escolha a pizza (M)ussarela ou (C)alabresa)");

var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
	PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriaPizzaria(localEscolhido);

	var pizza = pizzaria.MontaPizza(pizzaEscolhida);

	Console.WriteLine(pizza.Preparar());
	Console.WriteLine("\nPizza Concluída com Sucesso!");
}
catch (Exception ex)
{
	Console.WriteLine($"Erro: {ex.ToString()}");
}

Console.ReadLine();