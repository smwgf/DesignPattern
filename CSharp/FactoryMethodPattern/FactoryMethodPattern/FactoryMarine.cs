using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class FactoryMarine
    {
        public static IMarine CreateMarine<T>() where T : IMarine, new()
        {
            return new T();
        }
    }
}
