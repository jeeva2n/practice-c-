using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Test1
    {
        public int Marks { get; set; } = 55;

        public int marks
        {
            get
            {
                return Marks;
            }
            set
            {
                if (value >= 35)
                    Marks = value;
                else
                    Console.WriteLine("failed");
            }
        }
    }
}
