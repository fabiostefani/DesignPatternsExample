using System.Collections.Immutable;
using DesignPatternsExample.AbstractFactory;
using DesignPatternsExample.AbstractFactory.Factory;
using DesignPatternsExample.Builder;
using DesignPatternsExample.Builder.Models;
using DesignPatternsExample.FactoryMethod;
using DesignPatternsExample.Prototype;
using DesignPatternsExample.Singleton;

Executar();


void Executar()
{    
    AbstractFactory();        
    FactoryMethod();
    Builder();
    Prototype();
    Singleton();
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

void Prototype()
{
    Console.WriteLine("Builder");
    new ExecucaoPrototype().Executar();
    Console.WriteLine("==========================================");
    
}

void Singleton()
{
    Console.WriteLine("Singleton");
    new ExecucaoSingleton().Executar();
    Console.WriteLine("==========================================");
    
}

