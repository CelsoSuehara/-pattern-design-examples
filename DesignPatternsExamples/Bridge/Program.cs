using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefinedAbstraction;

var calculaSalario = new CalculaSalario(new GeraXML());

var funcionario = new Funcionario
{
    Id = 1,
    Nome = "John Lennon",
    SalarioBase = 7500,
    Incentivo = 1700
};

calculaSalario.ProcessaSalarioFuncionario(funcionario);

funcionario.Incentivo = 2000;

calculaSalario = new CalculaSalario(new GeraJson());

calculaSalario.ProcessaSalarioFuncionario(funcionario);

Console.ReadKey();