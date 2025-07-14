using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public abstract class AbstractCar
    {
        public int year;
        public abstract void Start();
    }

    class Ford : AbstractCar
    {
        public override void Start()
        {
            Console.WriteLine("Ford car started "+year);
        }
    }
    class Toyota : AbstractCar
    {
        public override void Start()
        {
            Console.WriteLine("Toyota car started "+year);
        }
    }
    class Benz :AbstractCar
    {
        public override void Start()
        {
            Console.WriteLine("Benz car started " + year);
        }
    }

}