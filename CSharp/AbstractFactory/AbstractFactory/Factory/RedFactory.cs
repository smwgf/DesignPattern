using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RedFactory : IFactory
    {
        string Me = "RedFactory";
        public IMarine CreateMarine()
        {
            Console.Write($"{Me} : ");
            return new RedMarine();
        }

        public IMedic CreateMedic()
        {
            Console.Write($"{Me} : ");
            return new RedMedic();
        }

        public ITank CreateTank()
        {
            Console.Write($"{Me} : ");
            return new RedTank();
        }
    }
}
