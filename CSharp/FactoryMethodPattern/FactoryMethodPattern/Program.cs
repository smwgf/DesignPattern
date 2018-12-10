using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMarine marine1 = FactoryMarine.CreateMarine<BlueMarine>();
            marine1.Shot();

            IMarine marine2 = FactoryMarine.CreateMarine<RedMarine>();
            marine2.Shot();
            Console.ReadLine();
        }
    }
}
