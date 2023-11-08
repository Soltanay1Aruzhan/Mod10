using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Window : IPart
    {
        public bool Ready { get; set; }=false;
        public void Build()
        {
            Console.WriteLine("Терезе дайын");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Терезе құрылды");
            }
            else
            {
                Console.WriteLine("Терезе құрылған жоқ");
            }
        }
    }
}
