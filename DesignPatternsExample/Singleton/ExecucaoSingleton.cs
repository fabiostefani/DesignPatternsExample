namespace DesignPatternsExample.Singleton;
public class ExecucaoSingleton
{
    public void Executar()
    {
        ClasseSingleton instance1 = ClasseSingleton.Instance();
        ClasseSingleton instance2 = ClasseSingleton.Instance();
        ClasseSingleton instance3 = ClasseSingleton.Instance();
        Console.WriteLine("Instancia 01 {0}", instance1.Id);
        Console.WriteLine("Instancia 02 {0}", instance2.Id);
        Console.WriteLine("Instancia 03 {0}", instance3.Id);
    }
}