using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_pia
{
    internal class Backpack
    {
        public int capacity;
        public List<Item> items;

        public Backpack(int capacity)
        {
            this.capacity = capacity;
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public int [] Solve()
        {
            items.Sort((x, y) => (y.value / y.weight).CompareTo(x.value / x.weight));
            int weightSum = 0;
            int valueSum = 0;
            foreach (Item item in items)
            {
                if (weightSum + item.weight <= capacity)
                {
                    weightSum += item.weight;
                    valueSum += item.value;
                }
                else
                {
                    break;
                }
            }
            int[] a = new int[] { weightSum, valueSum };
            return a;
        }
    }
}
