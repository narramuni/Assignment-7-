using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class NonGenericDemo
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();

            ht.Add(1, "Hello");
            ht.Add(2, 246);
            ht.Add("jhon", 3.246f);
            ht.Add(226, 12);

            Console.WriteLine("Hashtable 1:");


            foreach (DictionaryEntry item in ht) {

                Console.WriteLine(item.Key + " " + item.Value);    
            
            }

            Console.WriteLine("@@@@@@");

            ht.Remove(226);
            Console.WriteLine(  "after removing ");
            foreach (DictionaryEntry item in ht)
            {

                Console.WriteLine(item.Key + " " + item.Value);

            }

            Hashtable htt = new Hashtable(ht);

            Console.WriteLine("\n new Hashtable (htt):");

            foreach (DictionaryEntry item in ht)
            {

                Console.WriteLine(item.Key + " " + item.Value);

            }

            Console.WriteLine("ht");


            foreach (DictionaryEntry item in ht)
            {

                Console.WriteLine(item.Key + " " + item.Value);

            }





            //Queue queue = new Queue();
            //queue.Enqueue("India");
            //queue.Enqueue("Aus");
            //queue.Enqueue("Eng");

            //foreach (var item in queue) {
            //    Console.WriteLine(  item);

            //}


            //queue.Dequeue();
            //Console.WriteLine("After Dequeue");
            //foreach(var item  in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue q = new Queue(queue);
            //Console.WriteLine("queue");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("q:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //queue.Clear();
            //Console.WriteLine("Original Queue after clearing:");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}




            Console.ReadLine();


            //Stack s = new Stack();
            //s.Push(76);


            //s.Push("Hello");


            //s.Push(96.264d);

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********");


            //s.Pop();
            //Console.WriteLine("Stack after one pop operation:");

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********");         
            //Stack stack = new Stack(s);
            //Console.WriteLine("s:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("stack:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********");


            //s.Clear();
            //Console.WriteLine("Original Stack after clearing:");
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********");
            //Console.ReadLine();
        }

    }
}


