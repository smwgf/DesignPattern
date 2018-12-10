using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class RedMarine : IMarine
    {
        string Me = "Red Marine";
        public RedMarine()
        {
            Console.WriteLine($"{Me} Created");
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
