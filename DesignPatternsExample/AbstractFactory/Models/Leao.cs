namespace DesignPatternsExample.AbstractFactory.Models;
public class Leao : Carnivoro
{
    public override void Devorar(Herbivoro herbivoro) =>     
        Console.WriteLine($"{GetType().Name} devora {herbivoro.GetType().Name}");    
}