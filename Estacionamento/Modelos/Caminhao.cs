using Estacionamento.Modelos;

namespace Estacionamento.Modelos
{
    public class Caminhao : Veiculo
    {
        public override decimal CalcularValor(int horas)
        {
            return (horas * 18) + 20;
        }
    }
}