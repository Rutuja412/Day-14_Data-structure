using System;

namespace UC6_PopLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.popLast();
            linkedList.Display();
        }
    }
}
