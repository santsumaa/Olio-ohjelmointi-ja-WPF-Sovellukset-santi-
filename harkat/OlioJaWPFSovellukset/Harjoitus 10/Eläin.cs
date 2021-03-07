using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    abstract class Eläin
    {
        public string Name { get; set; }

        public abstract void MakeASound();
    }
}
