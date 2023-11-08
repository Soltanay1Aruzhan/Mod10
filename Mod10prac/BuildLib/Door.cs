using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Door : IPart
    {
        public bool Ready { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Есік дайын");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Есік құрылды");
            }
            else
            {
                Console.WriteLine("Есік құрылған жоқ");
            }
        }
    }
}
