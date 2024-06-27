using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._06
{
    class Item
    {
        public string name, description;
        public double price;

        public Item(string name, string desc, double pri)
        {
            this.name = name;
            description = desc;
            price = pri;
        }

        public Item Sravnenie(Item item1, Item item2)
        {
            List<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);
            items.OrderBy(k => k.description.Length).ThenBy(k => k.price);
            return items[0];
        }

        public override string ToString()
        {
            return $"{name} - {description} ({price})";
        }
    }

    class ItemList
    {
        List<Item> items;

        public ItemList()
        {
            items = new List<Item>();
        }
        public int size()
        {
            return items.Count();
        }

        public Item get(int i)
        {
            return items[i];
        }

        public void add(Item item)
        {
            items.Add(item);
            items.OrderBy(k => k.description.Length).ThenBy(k => k.price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ItemList items = new ItemList();
            Console.Write("n = ");int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Name = ");string name = Console.ReadLine();
                Console.Write("Description = "); string description = Console.ReadLine();
                Console.Write("Price = "); double price = double.Parse(Console.ReadLine());
                Item item = new Item(name, description, price);
                items.add(item);
            }
            for(int i = 0; i < items.size(); i++)
            {
                Console.WriteLine(items.get(i).ToString());
            }
        }
    }
}
