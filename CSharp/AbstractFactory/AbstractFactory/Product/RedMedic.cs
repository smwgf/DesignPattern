using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RedMedic : IMedic
    {
        string Me = "Red Medic";
        public RedMedic()
        {
            Console.WriteLine($"{Me} Created");
        }
        public void Heal()
        {
            Console.WriteLine($"{Me} Heal");
        }

        public void Move()
        {
            Console.WriteLine($"{Me} Move");
        }
    }
}
