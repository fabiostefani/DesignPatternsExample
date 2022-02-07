using DesignPatternsExample.FactoryMethod.Factory;
using DesignPatternsExample.FactoryMethod.Models;

namespace DesignPatternsExample.FactoryMethod;
public class CriarClassesFactoryMethod
{
    public void Executar()
    {
        var veiculoFactory = new ConcreteVeiculoFactory();
        Veiculo moto = veiculoFactory.Criar(Categoria.Leve);
        Console.WriteLine($"Limite de velocidade para {moto.GetType().Name} é: {moto.ObterLimite()}");
        Veiculo carro = veiculoFactory.Criar(Categoria.Medio);
        Console.WriteLine($"Limite de velocidade para {carro.GetType().Name} é: {carro.ObterLimite()}");
        Veiculo caminhao = veiculoFactory.Criar(Categoria.Pesado);
        Console.WriteLine($"Limite de velocidade para {caminhao.GetType().Name} é: {caminhao.ObterLimite()}");
    }
}