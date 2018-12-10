using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BlueFactory : IFactory
    {
        string Me = "BlueFactory";
        public IMarine CreateMarine()
        {
            Console.Write($"{Me} : ");
            return new BlueMarine();
        }

        public IMedic CreateMedic()
        {
            Console.Write($"{Me} : ");
            return new BlueMedic();
        }

        public ITank CreateTank()
        {
            Console.Write($"{Me} : ");
            return new BlueTank();
        }
    }
}
