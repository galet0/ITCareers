using System;

namespace _248_VegetablesStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            double result = ((vegetablesKg * vegetablesPrice) + (fruitsKg * fruitsPrice))/1.94;

            Console.WriteLine($"{result:f2}");
        }
    }
}
