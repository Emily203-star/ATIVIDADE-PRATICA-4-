using Estacionamento.Modelos;

namespace Estacionamento.Modelos
{
    public class Moto : Veiculo
    {
        public override decimal CalcularValor(int horas)
        {
            return horas * 5;
        }
    }
}