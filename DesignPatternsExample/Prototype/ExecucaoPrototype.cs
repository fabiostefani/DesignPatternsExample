namespace DesignPatternsExample.Prototype
{
    public class ExecucaoPrototype
    {
        public void Executar()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1();
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("C1 {0} Cloned P1 {1}", c1.Id, p1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2();
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("C2 {0} Cloned P2 {1}", c2.Id, p2.Id);
        }
    }
}