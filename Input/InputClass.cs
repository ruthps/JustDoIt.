using System;
using System.Collections.Generic;
using System.Text;

namespace JustDoIt.Input
{
    class InputClass
    {
        public static string Input(string info)
        {
            Console.Write(info + " : ");
            var data = Console.ReadLine();
            return data;
        }
    }
}
