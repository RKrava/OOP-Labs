using lab8_lib;
using System;

namespace lab8_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Notify += DisplayMessage;
            stack.Push(2);
            stack.Clear();
            stack.Push(3);
            
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
