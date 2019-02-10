using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Object box = Boxing(value);

            int unboxedValue = Unboxing(box);
            Console.WriteLine($"The value unboxed: {unboxedValue}");
            Console.Read();
        }
        private static Object Boxing(int value)
        {
            Object box = value;
            return box;
        }
        private static int Unboxing(Object box) => (int)box;
    }
}
