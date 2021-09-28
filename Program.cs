using System;
using System.Collections.Generic;
namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objectList = new List<object>();
            objectList.Add(7); 
            objectList.Add(28); 
            objectList.Add(-1); 
            objectList.Add(true);
            objectList.Add("chair");

            int sum = 0;
            foreach (object item in objectList)
            {
                Console.WriteLine(item);
                if (item is int)
                {
                    sum += (int)item;
                }
                
                
            }
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
    }
}
