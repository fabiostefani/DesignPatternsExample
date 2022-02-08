using DesignPatternsExample.Builder.Builders;

namespace DesignPatternsExample.Builder
{
    public class ExecucaoBuilder
    {        
        public void Executar()
        {
            Fabrica fabrica = new Fabrica();
            var scooterBuilder = new ScooterBuilder();
            fabrica.Construir(scooterBuilder);
            scooterBuilder.Veiculo.Show();

            var carro = new CarroBuilder();
            fabrica.Construir(carro);
            carro.Veiculo.Show();

            var motocicleta = new MotocicletaBuilder();
            fabrica.Construir(motocicleta);
            motocicleta.Veiculo.Show();
        }
    }
}