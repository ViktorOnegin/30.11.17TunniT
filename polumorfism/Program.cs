using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polumorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kujund1 = new Kujund();
            Kujund1.x = 10;
            Kujund1.y = 20;
            Kujund1.laius = 30;
            Kujund1.kõrgus = 40;

            var Ring1 = new Ring();
            Ring1.x = 5;
            Ring1.y = 16;
            Ring1.laius =10;
            Ring1.kõrgus = 10;

            var Ristkülik1 = new Ristkülik();
            Ristkülik1.x = 25;
            Ristkülik1.y = 35;
            Ristkülik1.laius = 55;
            Ristkülik1.kõrgus = 40;

            var kujund = new List<Kujund>();
            kujund.Add(Kujund1);
            kujund.Add(Ring1);
            kujund.Add(Ristkülik1);

            foreach (var item in kujund) 
            {
                Console.WriteLine("performing task");
            }

            Console.ReadLine();
        }
    }
}
