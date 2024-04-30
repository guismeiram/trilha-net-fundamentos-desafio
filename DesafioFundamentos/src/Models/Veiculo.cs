using DesafioFundamentos.src.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.src.Models
{
    public class Veiculo : Entity
    {
        public string Placa { get; set; }
        public string NomeFabricante { get; set; }
        public string NomeVeiculo { get; set; }

        public string Dados(string dados)
        {
            return dados;
        }
    }
}
