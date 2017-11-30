using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polumorfism
{
    class Kujund
    {
        public int x { get; set; }
        public int y { get; set; }
        public int kõrgus { get; set; }
        public int laius { get; set; }

        public virtual void Drow()
        {
            Console.WriteLine("Joonista");
        }
    }
}
 
