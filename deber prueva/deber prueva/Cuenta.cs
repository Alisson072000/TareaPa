using System.Threading;

namespace deber_prueva
{
    public class Cuenta
    {
        public double Equilibrar { get; set; }
        public Cuenta(double suma)
        {
            Equilibrar = suma;
        }
        public int CalCreditoPuntos()
        {
            Thread.Sleep(400);
            return (int)Equilibrar / 10;
        }
    }
}