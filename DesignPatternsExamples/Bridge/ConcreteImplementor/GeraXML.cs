using Bridge.Domain;
using Bridge.Implementor;
using System.Xml.Serialization;

namespace Bridge.ConcreteImplementor;

public class GeraXML : IGeraArquivo
{
    private string nomeArquivo = "SalarioFuncionario.xml";
    private XmlSerializer serializer = new XmlSerializer(typeof(Funcionario));
    private FileStream fileStream;

    public void GravaArquivo(Funcionario funcionario)
    {
        fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);

        serializer.Serialize(fileStream, funcionario);

        Console.WriteLine($"Salário para funcionário {funcionario.Nome} gerado com sucesso em {nomeArquivo} \n");
    }
}
