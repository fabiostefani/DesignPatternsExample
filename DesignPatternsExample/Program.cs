using DesignPatternsExample.AbstractFactory;
using DesignPatternsExample.AbstractFactory.Factory;

Executar();


void Executar()
{
    Console.WriteLine("Abstract Factory");
    AbstractFactory();
}

void AbstractFactory()
{
    var animaisAfrica = new AnimaisClient(new AfricaFactory());
    animaisAfrica.CacarComida();

    var animaisAmerica = new AnimaisClient(new AmericaFactory());
    animaisAmerica.CacarComida();
}