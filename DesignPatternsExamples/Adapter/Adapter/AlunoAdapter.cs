using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;

namespace Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        private SistemaMensalidade sistemaMensalidade = new SistemaMensalidade();

        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string id = null;
            string nome = null;
            string curso = null;
            string mensalidade = null;

            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else if (j == 2)
                    {
                        curso = alunosArray[i, j];
                    }
                    else if (j == 3)
                    {
                        mensalidade = alunosArray[i, j];
                    }
                }

                alunos.Add(new Aluno(Convert.ToInt32(id), nome, curso, Convert.ToDecimal(mensalidade)));
            }

            Console.WriteLine("O Adapter converteu o Array para List de Alunos\n");

            Console.WriteLine("E delegou ao sistema mensalidade o processamento da mensalidade dos alunos.\n");

            sistemaMensalidade.CalculaMensalidade(alunos);
        }
    }
}
