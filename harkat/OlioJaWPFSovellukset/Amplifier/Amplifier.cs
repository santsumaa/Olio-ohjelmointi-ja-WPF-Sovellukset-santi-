using System;
using System.Collections.Generic;
using System.Text;

namespace Amplifier
{
    class Amplifier
    {
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Annettu arvo " + value + " on liian suuri");
                    value = 100;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Annettu arvo " + value + " on liian pieni");
                    value = 0;
                }
                
                volume = value;
            }
        }
    }
}
