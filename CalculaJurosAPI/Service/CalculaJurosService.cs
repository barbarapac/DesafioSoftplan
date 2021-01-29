using CalculaJurosAPI.Interface;
using System;

namespace CalculaJurosAPI.Service
{
    public class CalculaJurosService : ICalculaJuros
    {
        public double CalculaJurosComposto(decimal ValorInicial, int Meses, double TaxaJuros)
        {
            try
            {
                if (ValorInicial <= 0 || Meses <= 0 || TaxaJuros <= 0)
                {
                    throw new Exception("Os valores informados são invalidos!");
                }

                var ValorFinal = (double)ValorInicial * Math.Pow((TaxaJuros + 1), Meses);
                return TrucarSemRound(ValorFinal);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double TrucarSemRound(double ValorFinal)
        {
            try
            {
                return (double)Math.Truncate(100 * ValorFinal) / 100;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
