using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    class Dagelan : IPagelaranWayang
    {
        public void Unsur()
        {
            Console.WriteLine("Dagelan merupakan Pelawak untuk melucu dalam pertunjukkan Wayang.");
            Console.WriteLine("Dagelan bukan merupakan acara pokok dalam pertunjukkan Wayang, hanya sebagai tambahan.");
            Console.WriteLine("Anggota Dagelan biasanya berbentuk tim atau berpasangan.");
        }
    }
}
