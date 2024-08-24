using Builder.ConcreteBuilder;
using Builder.Director;

var pizzaria = new Pizzaria(new PizzaCalabresa());
pizzaria.MontaPizza();
var pizza1 = pizzaria.GetPizza();
pizza1.PizzaConteudo();

pizzaria = new Pizzaria(new PizzaMussarela());
pizzaria.MontaPizza();
var pizza2 = pizzaria.GetPizza();
pizza2.PizzaConteudo();

Console.ReadKey();