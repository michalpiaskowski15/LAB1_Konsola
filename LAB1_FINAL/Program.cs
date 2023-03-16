using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_pia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz pojemnosc plecaka: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write("Wprowadz ilosc przedmiotow do wygenerowania: ");
            int numItems = int.Parse(Console.ReadLine());
            Random random = new Random(1); //tworzenie obiektu
            Backpack backpack = new Backpack(capacity);
            Console.WriteLine("Wygenerowane przedmioty:");
            Console.WriteLine("ID\tWaga\tWartosc");
            for (int i = 0; i < numItems; i++)
            {
                int weight = random.Next(1, 10);
                int value = random.Next(1, 20);
                Item item = new Item(i, weight, value);
                backpack.AddItem(item);
                Console.WriteLine(item.id + "\t" + weight + "\t" + value);
            }
            int weightSum = backpack.Solve()[0];
            int valueSum = backpack.Solve()[1];
            Console.WriteLine("\nW plecaku o pojemnosci " + capacity + " zmieszczono przedmioty o wartosci: " + valueSum + " i wadze: " + weightSum);
        }
    }
}
