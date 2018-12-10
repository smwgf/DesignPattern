using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new BlueFactory();
            IMarine marine = factory.CreateMarine();
            IMedic medic = factory.CreateMedic();
            ITank tank = factory.CreateTank();
            marine.Shot();
            medic.Heal();
            tank.Move();

            factory = new RedFactory();
            IMarine marine2 = factory.CreateMarine();
            IMedic medic2 = factory.CreateMedic();
            ITank tank2 = factory.CreateTank();
            marine2.Shot();
            medic2.Heal();
            tank2.Move();


            Console.ReadLine();
        }
    }
}
