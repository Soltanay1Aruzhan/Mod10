using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Walls : IPart
    {
        public bool Ready { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Қабырға дайын");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Қабырға құрылды");
            }
            else
            {
                Console.WriteLine("Қабырға құрылған жоқ");
            }
        }
    }
}
