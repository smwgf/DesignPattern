using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RedTank : ITank
    {
        string Me = "Red Tank";
        public RedTank()
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
