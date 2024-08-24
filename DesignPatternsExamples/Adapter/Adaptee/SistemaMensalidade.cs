using Adapter.Domain;

namespace Adapter.Adaptee;

public class SistemaMensalidade
{
    public void CalculaMensalidade(List<Aluno> alunos)
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Aluno {aluno.Nome} - valor da mensalidade R$ {aluno.Mensalidade}");
        }
    }
}
