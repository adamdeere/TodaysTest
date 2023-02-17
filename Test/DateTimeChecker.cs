using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class DateTimeChecker
    {
       
         
        //Write a program in C# Sharp to compute what day was yesterday.  
        public string ReturnTodaysDate()
        {
            string shortDateString = DateTime.Now.ToShortDateString();
            return shortDateString;
        }
        public string ReturnYesterdaysDate() 
        {
            string shortDateString = DateTime.Now.AddDays(-1).ToString();
            return shortDateString;
        }
    }
}
