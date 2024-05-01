using DesafioFundamentos.src.Enums;
using DesafioFundamentos.src.Models;
using DesafioFundamentos.src.Models.Base;

namespace DesafioFundamentos.Models
{
    public class Estacionamento : Entity
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> Veiculos = new List<Veiculo>();
        private Status status;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public decimal CalculoPrecoEstadia(decimal valor)
        {
            return valor;
        }

        public DateTime HorasEstacionamento(DateTime horasEstacionamento)
        {
            return horasEstacionamento;
        }


    }
}
