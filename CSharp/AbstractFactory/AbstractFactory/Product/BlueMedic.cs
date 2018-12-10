using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BlueMedic : IMedic
    {
        string Me = "Blue Medic";
        public BlueMedic()
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
