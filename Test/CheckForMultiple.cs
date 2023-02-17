using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CheckForMultiple
    {
        // positive number is a multiple of 3 or a multiple of 7.
        public void DoCheck(int range)
        {
            for (int i = 0; i < range; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(true);
                }
                else 
                { 
                    Console.WriteLine(false); 
                }
                
            }
        }
    }
}
