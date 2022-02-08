using System.Collections.Immutable;
using DesignPatternsExample.AbstractFactory;
using DesignPatternsExample.AbstractFactory.Factory;
using DesignPatternsExample.Builder;
using DesignPatternsExample.Builder.Models;
using DesignPatternsExample.FactoryMethod;

Executar();


void Executar()
{    
    AbstractFactory();        
    FactoryMethod();
    Builder();
}

void AbstractFactory()
{
    Console.WriteLine("Abstract Factory");
    var animaisAfrica = new AnimaisClient(new AfricaFactory());
    animaisAfrica.CacarComida();

    var animaisAmerica = new AnimaisClient(new AmericaFactory());
    animaisAmerica.CacarComida();
    Console.WriteLine("==========================================");
}

void FactoryMethod()
{
    Console.WriteLine("Factory Method");
    new CriarClassesFactoryMethod().Executar();    
    Console.WriteLine("==========================================");
}

void Builder()
{
    Console.WriteLine("Builder");
    new ExecucaoBuilder().Executar();
    Console.WriteLine("==========================================");
}