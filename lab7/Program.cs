using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Add(1.1);
            ll.Add(2);
            ll.Add(3.2);
            ll.Add(4.1);
            ll.Remove(2);

            Console.WriteLine("List: ");
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Number of elements bigger than avg - {ll.NumberOfElementsBiggerThanAvg()}");
            ll.RemoveOdd();
            Console.WriteLine("List after deleting even items:");
            foreach(var item in ll)
            {
                Console.WriteLine(item);
            }
        }
    }
}
