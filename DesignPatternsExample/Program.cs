using DesignPatternsExample.AbstractFactory;
using DesignPatternsExample.AbstractFactory.Factory;
using DesignPatternsExample.FactoryMethod;

Executar();


void Executar()
{
    Console.WriteLine("Abstract Factory");
    AbstractFactory();    
    Console.WriteLine("Factory Method");
    FactoryMethod();
}

void AbstractFactory()
{
    var animaisAfrica = new AnimaisClient(new AfricaFactory());
    animaisAfrica.CacarComida();

    var animaisAmerica = new AnimaisClient(new AmericaFactory());
    animaisAmerica.CacarComida();
    Console.WriteLine("==========================================");
}

void FactoryMethod()
{
    new CriarClassesFactoryMethod().Executar();    
    Console.WriteLine("==========================================");
}