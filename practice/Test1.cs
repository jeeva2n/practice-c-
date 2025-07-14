using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Test1
    {
        private int Marks { get; set; } = 55;
        public string Name { get; set; } = "abcd";

        public int marks
        {
            set
            {
                if (value >= 35)
                    Marks = value;
                else
                    Console.WriteLine("failed");
            }

            get
            {
                return Marks;
            }
            
        }
    }
}
