using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Количество товара                     ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Стоимость товара за 1 еденицу         ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Количество денег в кошельке           ");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Купили товара                         ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"    {"Денег хватает на"}     {(m / c) * 1}      {"единиц товара"}");

            Console.WriteLine();

            float k;
            k = (m - (b * c));
            Console.WriteLine($"           {k}        {"Остаток в кошельке"}");
            if (k <= 0)
            { Console.WriteLine("          Нехватает денег"); }


            Console.WriteLine();

            if (m == 0)
            { Console.WriteLine($"           {"Денег не хватает даже на один товар"} "); }

            else if (m > ((n + c) * n))
            { Console.WriteLine($"      {"Денег больше, чем надо (можно было бы купить больше чем"} {n}  {"единиц товара)"}"); }

            Console.WriteLine();

            Console.WriteLine($"            {m - (b * c)}          {"Ваша сдача"}");
            if ((m - (b * c)) <= 0)
            { Console.WriteLine("           Нехватает денег");}

            Console.ReadKey();






        }
    }
}
