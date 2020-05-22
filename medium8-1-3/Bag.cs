using System;
using System.Collections.Generic;
using System.Linq;

namespace medium8_1_3
{
    public class Bag
    {
        private readonly List<Item> _items;
        public int MaxWeidth { get; private set; }

        public Bag(int maxWeidth = 1)
        {
            if(maxWeidth < 1)
            {
                throw new InvalidOperationException();
            }

            MaxWeidth = maxWeidth;
            _items = new List<Item>();
        }

        public bool AddItem(Item item)
        {
            int currentWeidth = _items.Sum(bagItem => bagItem.Count);           

            if ((currentWeidth + item.Count) > MaxWeidth)
            {
                return false;
            }
            else
            {
                Item targetItem = _items.FirstOrDefault(bagItem => bagItem.Name == item.Name);
                if(targetItem == null)
                {
                    _items.Add(item);
                }
                else
                {
                    Item newItem = new Item(targetItem, item.Count);

                    _items.Remove(targetItem);
                    _items.Add(newItem);
                }
            }

            return true;
        }

        public IEnumerable<Item> ShowBag() => _items;
    }
}
