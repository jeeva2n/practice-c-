using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
        internal class Test4
        {
            public static void swap(int aa,int bb)
            {
                int temp = aa;
                aa = bb;
                bb = temp;

                Console.WriteLine("Inside Swap:");
                Console.WriteLine($"aa = {aa}, bb = {bb}");
            }
        }
    
}
