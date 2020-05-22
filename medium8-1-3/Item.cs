using System;
using System.Threading;

namespace medium8_1_3
{
    public class Item
    {
        public int Count { get; private set; }
        public string Name { get; private set; }

        public Item(Item item, int addCount)
        {
            CheckCount(addCount);

            Name = item.Name;
            Count = addCount + item.Count;
        }

        public Item(string name, int count = 1)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            CheckCount(count);

            Name = name;
            Count = count;
        }

        private void CheckCount(int count)
        {
            if (count < 1)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
