namespace SingletonMultiThread;

public class Singleton
{
    private static Singleton instance = null;

    private static object instanceLock = new object();

    private int numeroDeInstancias = 0;

    private Singleton()
    {
        Console.WriteLine("Instanciando dentro do construtor privado.");
        numeroDeInstancias++;
        Console.WriteLine($"Número de instâncias: {numeroDeInstancias}");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        Console.WriteLine("Criando a primeira instância");
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}