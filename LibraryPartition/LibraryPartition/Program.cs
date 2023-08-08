using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LibraryPartition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press the starting number");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press the ending number");
            int end = Convert.ToInt32(Console.ReadLine());

            myLibrary library = new myLibrary();

            Console.WriteLine("Sonuc : {0}" , library.NumberPlus(start, end));

            Console.ReadKey();

        }
    }
}
                                                      