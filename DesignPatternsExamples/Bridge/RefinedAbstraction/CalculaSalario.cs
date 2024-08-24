using Bridge.Abstraction;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.RefinedAbstraction;

public class CalculaSalario : AbstractionGeraArquivo
{
    public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo)
    {
    }

    public void ProcessaSalarioFuncionario(Funcionario funcionario)
    {
        funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

        Console.WriteLine($"Valor do salário total para o funcionário: {funcionario.Nome} > R$ {funcionario.SalarioTotal}");

        _geraArquivo.GravaArquivo(funcionario);
    }
}
