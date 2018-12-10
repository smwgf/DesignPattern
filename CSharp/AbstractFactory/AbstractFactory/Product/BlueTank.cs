using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BlueTank : ITank
    {
        string Me = "Blue Tank";
        public BlueTank()
        {
            Console.WriteLine($"{Me} Created");
        }
        public void ChaneMode()
        {
            Console.WriteLine($"{Me} ChaneMode");
        }

        public void Move()
        {
            Console.WriteLine($"{Me} Move");
        }

        public void Shot()
        {
            Console.WriteLine($"{Me} Shot");
        }
    }
}
