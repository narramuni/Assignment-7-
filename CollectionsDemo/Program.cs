using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList a = new ArrayList();
            a.Add(24);
            a.Add(4.6843);
            a.Add(25);
            a.Add("giri");
            a.Add("one");
            a.Add(5612);
            a.Add("two");
            a.Add(12);
            a.Add(96);
            a.Add(92);
            Console.WriteLine(  );

            foreach (var item in a)
            {
                Console.WriteLine(item);

            }
            a.Remove("25");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


            object[] objarr = new object[a.Count];
            a.CopyTo(objarr);
            int i = 0;

                

            foreach (object obj in objarr)
            {
                Type t = obj.GetType(); 

                if (t != typeof(int))
                {
                    objarr[i] = 0; 
                }
                i++;
            }

            Console.WriteLine("Now the contents of the array:");

            foreach (var item in objarr)
            {
                Console.WriteLine(item);
            }

            Array.Sort(objarr);

            Array.Reverse(objarr);

            Console.WriteLine("Sorted and Reversed Array:");

            foreach (var item in objarr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
