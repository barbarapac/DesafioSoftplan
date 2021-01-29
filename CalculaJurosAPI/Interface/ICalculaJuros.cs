using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosAPI.Interface
{
    public interface ICalculaJuros
    {
        decimal CalculaJurosComposto(decimal ValorInicial, int Meses, decimal TaxaJuros);

    }
}
