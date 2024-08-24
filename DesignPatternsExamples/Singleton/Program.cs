Console.WriteLine("Teste Singleton");
Console.WriteLine("Criando uma instância de singleton s1");

Singleton.Singleton s1 = Singleton.Singleton.Instance;

Console.WriteLine("Criando uma instância de singleton s2");

Singleton.Singleton s2 = Singleton.Singleton.Instance;

if (s1 == s2)
    Console.WriteLine("Existem somente uma instância");
else 
    Console.WriteLine("Existem instâncias diferentes");

Console.ReadKey();