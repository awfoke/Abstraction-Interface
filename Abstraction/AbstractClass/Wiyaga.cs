using System;

namespace Abstraction.AbstractClass
{
    public class Wiyaga : PagelaranWayang
    {
        public override void Unsur()
        {
            Console.WriteLine("Wiyaga adalah orang yang memainkan Gamelan.");
            Console.WriteLine("Bunyi gamelan yang dimainkan Wiyaga berguna untuk mengiringi jalannya Pertunjukkan Wayang.");
            Console.WriteLine("Wiyaga terdiri dari beberapa orang sesuai alat musiknya masing-masing.");
        }
    }
}
