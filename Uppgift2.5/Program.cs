using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en beräkning i formatet tal1*tal2 : " );
            string Beräkning = Console.ReadLine();

            int GångerIndex = Beräkning.IndexOf("*");

            string strTal1 = Beräkning[..GångerIndex];

            string strTal2 = Beräkning[(GångerIndex + 1)..];

            double Tal1 = Convert.ToDouble(strTal1);
            double Tal2 = Convert.ToDouble(strTal2);

            Console.WriteLine(Tal1 + " * " + Tal2 + " = " + (Tal1*Tal2));

        }
    }
}
