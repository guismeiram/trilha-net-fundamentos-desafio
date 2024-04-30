using DesafioFundamentos.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.src.Interface
{
    public interface IEstacionamentoRepository
    {
        void AdicionarVeiculo(Veiculo veiculo);
        void RemoverVeiculo(Veiculo veiculo);
        void ListarVeiculos(Veiculo veiculo);
    }
}
