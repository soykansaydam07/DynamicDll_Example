using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Olusturulan Dll yapsıını assambly kısmına bagladım.
            Assembly myassembly = Assembly.LoadFrom(@"C:\Users\soykan\Desktop\C\C Working\MyLibrary\MyLibrary\bin\Debug\MyLibrary.dll");
           
            //my types oluşturduğum dll de kaç sınıf var oldugunu döndurucek.
            Type[] mytypes = myassembly.GetTypes();
            
            //activator instance oluştururak bir classın nesnesini oluşturmus gibi onu kullanabiliriz
            object instance = Activator.CreateInstance(mytypes[0]);
            
            //Class da oluşturulmuş butun metodları bu dizide object tabanlı alarak sıralama yapacaktır.
            MethodInfo[] mymethods = mytypes[0].GetMethods();

            Console.WriteLine("Enter the start number");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the finish number");
            int finish = Convert.ToInt32(Console.ReadLine());
            
            // Invoke yapısı ile istenen metoda degerler göderiliyor.
            Console.WriteLine( "Sonuc : {0}" , mymethods[0].Invoke(instance, new object[] { start, finish })); 
           
        }
    }
}
