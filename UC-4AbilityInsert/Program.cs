using System;

namespace UC_4AbilityInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            // linkedList.Add(30);
            linkedList.InsertAtParticularPosition(2, 20);
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}
