using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polumorfism
{
    class Ristkülik: Kujund
    {
        public virtual void Draw()
        {
            Console.WriteLine("Joonista Ristkülik");
            base.Drow();
        }
    }
}
