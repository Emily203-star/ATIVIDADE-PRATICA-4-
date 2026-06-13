using Estacionamento.Modelos;

namespace Estacionamento.Modelos
{
    public class Carro : Veiculo
    {
        public override decimal CalcularValor(int horas)
        {
            return horas * 10;
        }
    }
}