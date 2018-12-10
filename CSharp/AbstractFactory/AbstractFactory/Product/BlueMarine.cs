using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BlueMarine : IMarine
    {
        string Me = "Blue Marine";
        public BlueMarine()
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
