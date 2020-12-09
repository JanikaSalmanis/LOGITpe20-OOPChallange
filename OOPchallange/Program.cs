using System;

namespace OOPchallange
{
    class Program
    {
        class Cat
        {
            string name;
            double hungry;
            string color;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungry = 0;
                Console.WriteLine($"The cat {name} has been created.");
            }

            public double Hungry
            {
                get { return hungry; }
            }
            public void Sleep()
            {
                Console.WriteLine("sleep");
                hungry += 0.2;
            }

            public void Meow()
            {
                Console.WriteLine("Meow-Meow");
            }

            public void Rename(string newName)
            {
                name = newName;
            }

            public void ShowCatData()
            {
                Console.WriteLine($"Name: {name};Color {color} Hungry: {Hungry};");
            }

        }

        static void Main(string[] args)
        {
            Cat newCat = new Cat ("kass", "black");

            Console.WriteLine($"The level of hungry: {newCat.Hungry}");

            while (newCat.Hungry != 1)
            {
                newCat.Sleep();
            }

            newCat.Meow();

            Console.WriteLine("Name the Cat: ");
            string newCatName = Console.ReadLine();
            newCat.Rename(newCatName);
            newCat.ShowCatData();

        }
    }
}
