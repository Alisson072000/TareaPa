using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace deber_prueva
{
    class Program
    {
        public static List<Cuenta> Cuentas = new List<Cuenta>();
        public static void Main(string[] args)
        {
            CrearCuentas();
            Console.WriteLine("Paralelo......" + CalcParalelo());
            Console.WriteLine("Serial........" + CalcSerial());
            Console.ReadKey();

        }
        public static double CalcSerial()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < Cuentas.Count; i++)
            {
                Console.WriteLine("procedimiento Serial {0}" , Cuentas[i].CalCreditoPuntos());
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
        public static double CalcParalelo()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.ForEach(Cuentas, Cuenta =>
            {
                Console.WriteLine("Proceso Paralelo {0}" , Cuenta.CalCreditoPuntos());

            });
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
        public static void CrearCuentas()
        {
            double[] suma = { 12, 8000, 18000, -400, 5400, 8000, 2240 };
            foreach(double sumas in suma)
            {
                Cuentas.Add(new Cuenta(sumas));
            }
            
        }




    }
}

