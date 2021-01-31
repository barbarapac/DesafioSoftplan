using TaxaJurosAPI.Interfaces;

namespace TaxaJurosAPI.Services
{
    public class TaxaJurosService : ITaxaJuros
    {
        public double TaxaJurosComposto()
        {
            return 0.01;
        }
    }
}
