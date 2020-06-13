using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    class Sinden : IPagelaranWayang
    {
        public void Unsur()
        {
            Console.WriteLine("Sinden adalah penyanyi yang menyanyikan Tembang (lagu) Jawa.");
            Console.WriteLine("Nyanyian Sinden digunakan untuk mengiringi lagu cerita Wayang.");
            Console.WriteLine("Sinden biasanya diperankan oleh Wanita.");
        }
    }
}
