using DesafioFundamentos.src.Models;
using DesafioFundamentos.src.Models.Base;

namespace DesafioFundamentos.Models
{
    public class Estacionamento : Entity
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

       
    }
}
