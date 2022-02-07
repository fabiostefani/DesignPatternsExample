using DesignPatternsExample.FactoryMethod.Models;

namespace DesignPatternsExample.FactoryMethod.Factory;
public class ConcreteVeiculoFactory : VeiculoFactory
{
    public override Veiculo Criar(Categoria categoria)
    {
        switch (categoria)
        {
            case Categoria.Leve:
                return new Moto(Veiculo.LimiteVelocidadeLeve);
            case Categoria.Medio:
                return new Carro(Veiculo.LimiteVelocidadeMedio);
            case Categoria.Pesado:
                return new Caminhao(Veiculo.LimiteVelocidadePesado);
            default:
                throw new ApplicationException($"Veículo {categoria} não pode ser criado.");

        }
    }
}