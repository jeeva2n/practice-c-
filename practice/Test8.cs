using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public interface IBikename
    {
        void bikename();
    }

    public interface IBikemodel
    {
        void bikemodel();
    }


    public class Bike : IBikename, IBikemodel
    {
        public void bikename()
        {
            Console.WriteLine("It is Ninja Bike");
        }
        public void bikemodel()
        {
            Console.WriteLine("Latest Model");
        }
    }
}

