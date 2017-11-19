using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyArrayList<int> myList = new MyArrayList<int>(2);

                myList.Add(1);
                myList.Add(2);
                myList.Add(3);
                myList.Add(4);
                myList.Add(5);

                myList.Remove(2);
                myList.SetElement(3, 10);

                Console.WriteLine("Capacity is: " + myList.Capacity);

                Console.Write("\nThe array looks like: ");

                for (int i = 0; i < myList.Count; i++)
                {
                    Console.Write(myList.GetElement(i) + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
