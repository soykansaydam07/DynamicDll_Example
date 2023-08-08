using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class myLibrary
    {
        public int published;
        public int privated;
        public int NumberPlus(int starting, int ending )
        {
            int result = 0;
            while (starting <= ending)
            {
                result += starting;
                starting ++;
            }
            return result;
        }
        public string StringWriter(string cometoString)
        {
            string word = "Come to string : "; 
            word +=   cometoString;

            return word;
        }

    }
}
