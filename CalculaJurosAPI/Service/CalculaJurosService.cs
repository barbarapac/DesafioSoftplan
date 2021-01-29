using CalculaJurosAPI.Interface;
using System;

namespace CalculaJurosAPI.Service
{
    public class CalculaJurosService : ICalculaJuros
    {
        public decimal CalculaJurosComposto(decimal ValorInicial, int Meses, double TaxaJuros)
        {
            try
            {
                if (ValorInicial <= 0 || Meses <= 0 || TaxaJuros <= 0)
                {
                    throw new Exception("Os valores informados são invalidos!");
                }

                var ValorFinal = (ValorInicial * (decimal)Math.Pow(1 + TaxaJuros, Meses));
                return Math.Truncate(ValorFinal);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
