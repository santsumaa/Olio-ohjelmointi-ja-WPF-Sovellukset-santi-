﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Kala : Eläin, ICanSwim
    {
        public int SwimSpeed { get; set; }
        public string Sound { get; set; }

        public Kala(string _name, int _speed, string _sound)
        {
            Name = _name;
            SwimSpeed = _speed;
            Sound = _sound;
        }

        public override void MakeASound()
        {
            Console.WriteLine(Sound);
        }

        public void Swim()
        {
            Console.WriteLine("Kala {0} ui nopeudella {1}", Name, SwimSpeed);
        }
    }
}
