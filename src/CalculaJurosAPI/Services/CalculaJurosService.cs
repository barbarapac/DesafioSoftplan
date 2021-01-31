using CalculaJurosAPI.Interfaces;
using System;

namespace CalculaJurosAPI.Services
{
    public class CalculaJurosService : ICalculaJuros
    {
        public double CalculaJurosComposto(decimal valorInicial, int meses, double taxaJuros)
        {
            try
            {
                if (valorInicial <= 0 || meses <= 0 || taxaJuros <= 0)
                {
                    throw new Exception("Os valores informados são invalidos!");
                }

                var valorFinal = (double)valorInicial * Math.Pow((taxaJuros + 1), meses);
                return TrucarSemRound(valorFinal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double TrucarSemRound(double valorFinal)
        {
            try
            {
                return (double)(Math.Truncate(100 * valorFinal) / 100);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
