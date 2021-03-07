using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_7
{
    static class ErrorHelper
    {
        public static void KirjoitaError(string virhe)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Error message: " + virhe);
            Console.WriteLine("-----------");
        }
    }
}
