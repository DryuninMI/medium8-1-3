using System;
using System.Collections.Generic;
using System.Linq;

namespace medium8_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag(22);

            bag.AddItem(new Item("Sword"));
            bag.AddItem(new Item("Bow"));
            bag.AddItem(new Item("Arrow", 10));

            WriteItemsInConsole(bag.ShowBag());

            bag.AddItem(new Item("Arrow", 10));

            WriteItemsInConsole(bag.ShowBag());

            bag.AddItem(new Item("Bow", 2));

            WriteItemsInConsole(bag.ShowBag());
        }

        public static void WriteItemsInConsole(IEnumerable<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("In Bag");
            foreach (var item in items)
            {
                Console.WriteLine("Item: {0}, Count: {1}", item.Name, item.Count);
            }

            Console.WriteLine("Total count: {0}", items.Sum(item => item.Count));
        }
    }
}
