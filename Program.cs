using System;

namespace SalutacionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BonDia bonDia = new BonDia();
            BonaTarda bonaTarda = new BonaTarda();
            BonaNit bonaNit = new BonaNit();

            bonDia.Saludar();
            bonaTarda.Saludar();
            bonaNit.Saludar();
            Console.ReadLine();
        }
    }
}

