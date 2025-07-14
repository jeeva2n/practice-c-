using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public interface Icar
    {
    void carname();
    void carcolor();
     int year();
    }

    public class BMW : Icar
    {
        public void carname()
        {
            Console.WriteLine("It is BMW Car");
        }
        public void carcolor()
        {
            Console.WriteLine("Red Color");
        }

        public int year()
        {
            int year = 2023; 
            Console.WriteLine("new year: " + year);
            return year;
        }
    }



public class Honda : Icar
    {
        public void carname()
        {
            Console.WriteLine("It is Honda car");
        }
        public void carcolor()
        {
            Console.WriteLine("Black car");
        }

        public int year()
        {
            int year = 2023;
            Console.WriteLine("new year: " + year);
            return year;
        }
    }
}
