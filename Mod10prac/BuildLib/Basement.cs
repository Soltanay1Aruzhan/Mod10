﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Basement : IPart
    {
        public bool Ready { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Фундамент дайын");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Фундамент құрылды");
            }
            else 
            {
                Console.WriteLine("Фундамент құрылған  жоқ");
            }
            
        }
    }
}
