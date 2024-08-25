
using Composite.Composite;
using Composite.Leaf;

var organizacao = new Organizacao { Nome = "TesteSoft" };

var departamentoTI = new Organizacao { Nome = "TI" };
departamentoTI.Add(new Funcionario { Id = 1, Nome = "John Lennon", Horas = 40 });
departamentoTI.Add(new Funcionario { Id = 2, Nome = "Paul McCartney", Horas = 42 });
departamentoTI.Add(new Funcionario { Id = 3, Nome = "Geroge Harrison", Horas = 41 });
departamentoTI.Add(new Funcionario { Id = 4, Nome = "Ringo Starr", Horas = 36 });
organizacao.Add(departamentoTI);

var departamentoJuridico = new Organizacao { Nome = "Jurídico" };
departamentoJuridico.Add(new Funcionario { Id = 5, Nome = "Geddy Lee", Horas = 39 });
departamentoJuridico.Add(new Funcionario { Id = 6, Nome = "Neil Peart", Horas = 40 });
departamentoJuridico.Add(new Funcionario { Id = 7, Nome = "Alex Lifesson", Horas = 42 });
organizacao.Add(departamentoJuridico);

organizacao.GetHoraTrabalhada();

Console.ReadKey();