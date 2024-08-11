using PrototypeDeepCopy.ConcretePrototype;

Soldado soldado = new Soldado();
soldado.Nome = "Ryan";
soldado.Arma = "AK47";
soldado.Acessorio = new Acessorio { Nome = "Night vision" };

Soldado soldado_clone1 = (Soldado)soldado.Clone();
soldado_clone1.Nome = "Soldado Clonado 1";
soldado_clone1.Arma = "Sniper";
soldado_clone1.Acessorio.Nome = "Colete Especial";

Soldado soldado_clone2 = (Soldado)soldado.Clone();
soldado_clone2.Nome = "Soldado Clonado 2";
soldado_clone2.Arma = "AN97";
soldado_clone2.Acessorio.Nome = "Granada";

Console.WriteLine("Objeto Original");
Console.WriteLine($"{soldado.Nome} - {soldado.Arma} - {soldado.Acessorio.Nome}\n");

Console.WriteLine("Objeto Clonado 1");
Console.WriteLine($"{soldado_clone1.Nome} - {soldado_clone1.Arma} - {soldado_clone1.Acessorio.Nome}\n");

Console.WriteLine("Objeto Clonado 2");
Console.WriteLine($"{soldado_clone2.Nome} - {soldado_clone2.Arma} - {soldado_clone2.Acessorio.Nome}\n");
