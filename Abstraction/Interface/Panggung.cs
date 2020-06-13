using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    class Panggung : IPagelaranWayang
    {
        public void Unsur()
        {
            Console.WriteLine("Panggung merupakan tempat untuk pertunjukkan Wayang.");
            Console.WriteLine("Dalang, Sinden, Dagelan, dan yang lainnya tampil di Panggung");
            Console.WriteLine("Biasanya tempatnya agak tinggi dan beratap agar para penonton dapat melihat Pertunjukkan Wayang.");
        }
    }
}
