using System;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k >= 10)
            {
                Console.WriteLine("1. Число десятков = " + k / 10); 
                Console.WriteLine("2. Число единиц = {0}", k % 10);
                Console.WriteLine("3. Сумма его цифр = {0}", k % 10 + k / 10);
                Console.WriteLine("4. Произведение его цифр = " + ((k % 10) * (k / 10)));
            }
            else
            {
                Console.WriteLine("Введите число от 10!");
            }
        }
    }

}
