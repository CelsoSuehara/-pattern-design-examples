using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstraction;

public abstract class AbstractionGeraArquivo
{
    protected IGeraArquivo _geraArquivo;

    protected AbstractionGeraArquivo(IGeraArquivo geraArquivo)
    {
        _geraArquivo = geraArquivo;
    }

    public virtual void GravaArquivo(Funcionario funcionario)
    {
        _geraArquivo.GravaArquivo(funcionario);
    }
}
