using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class RemoveChracterInString
    {
        public string RemoveChracterInStringArray(string word, int position) 
        {
            char[] chars = word.ToCharArray();
            string result = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (i != position)
                {
                    result+= chars[i];
                }
            }
            return result;
        }
    }
}
