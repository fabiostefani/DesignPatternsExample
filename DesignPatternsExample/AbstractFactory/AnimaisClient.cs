using DesignPatternsExample.AbstractFactory.Factory;
using DesignPatternsExample.AbstractFactory.Models;

namespace DesignPatternsExample.AbstractFactory;
public class AnimaisClient
{
    private readonly Herbivoro _herbivoro;
    private readonly Carnivoro _carnivoro;
    public AnimaisClient(ContinenteFactory factory)
    {
        _carnivoro = factory.ObterCarnivoro();
        _herbivoro = factory.ObterHerbivoro();
    }

    public void CacarComida()
    {
        _carnivoro.Devorar(_herbivoro);
    }
}