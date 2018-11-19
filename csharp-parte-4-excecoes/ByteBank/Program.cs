using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           Console.ReadLine();

        }
        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
