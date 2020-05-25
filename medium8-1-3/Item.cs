using System;
using System.Threading;

namespace medium8_1_3
{
    public class Item
    {
        public uint Count { get; set; }
        public string Name { get; private set; }

        public Item(string name, uint count = 1)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (count < 1)
            {
                throw new NullReferenceException();
            }

            Name = name;
            Count = count;
        }            
    }
}
