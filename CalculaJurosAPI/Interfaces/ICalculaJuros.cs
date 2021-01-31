namespace CalculaJurosAPI.Interfaces
{
    public interface ICalculaJuros
    {
        double CalculaJurosComposto(decimal ValorInicial, int Meses, double TaxaJuros);

        double TrucarSemRound(double ValorFinal);
    }
}
