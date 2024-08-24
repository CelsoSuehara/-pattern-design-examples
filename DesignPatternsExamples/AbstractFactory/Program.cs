using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory;
using AbstractFactory.Infrastructure;

//Obter fábricas 
var boloFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

//Cria os objetos com base no tipo : bolo
var boloChocolate = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
var boloLaranja = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

//Cria os objetos com base no tipo : pizza
var pizzaCalabresa = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabresa);
var pizzaMussarela = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);

//Exibe os detalhes
ExibeDetalhes(boloChocolate);
ExibeDetalhes(boloLaranja);
ExibeDetalhes(pizzaCalabresa);
ExibeDetalhes(pizzaMussarela);

Console.ReadLine();

static void ExibeDetalhes(MassaBase massaBase)
{
    Console.WriteLine($"Tipo: {massaBase.TipoMassa}");
    Console.WriteLine(massaBase.Nome);
    massaBase.Ingredientes.WriteLines();
    Console.WriteLine("\n");
}