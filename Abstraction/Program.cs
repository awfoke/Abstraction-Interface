using System;

using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tPenggunaan AbstractClass\n");
            PagelaranWayang pagelaranwayang;

            pagelaranwayang = new WayangKulit();
            pagelaranwayang.Unsur();

            Console.WriteLine();
            pagelaranwayang = new Dalang();
            pagelaranwayang.Unsur();

            Console.WriteLine();
            pagelaranwayang = new Wiyaga();
            pagelaranwayang.Unsur();

            Console.WriteLine();

            Console.WriteLine("\tPenggunaan Interface\n");
            IPagelaranWayang ipagelaranwayang;

            ipagelaranwayang = new Sinden();
            ipagelaranwayang.Unsur();

            Console.WriteLine();
            ipagelaranwayang = new Dagelan();
            ipagelaranwayang.Unsur();

            Console.WriteLine();
            ipagelaranwayang = new Panggung();
            ipagelaranwayang.Unsur();

            Console.ReadKey();
        }
    }
}
