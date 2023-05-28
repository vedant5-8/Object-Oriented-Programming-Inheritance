using System;

namespace Object_Oriented_Programming_Inheritance
{
    /*
     * Hierarchical inheritance: A base class that serves as a parent class 
     * for two or more derived classes.
     */
    internal class Car
    {

        public string name;
        public string brand;

        public Car(string name, string brand )
        {
            this.name = name;
            this.brand = brand;
        }
    }

    internal class Nissan:Car
    {
        public int price;
        public int topSpeed;

        public Nissan(string name, string brand, int price, int topSpeed) : base(name, brand)
        {
            this.price = price;
            this.topSpeed = topSpeed;
        }

        public void NissanCarDetails()
        {
            Console.WriteLine("Car Name: {0}", name);
            Console.WriteLine("Car Brand: {0}", brand);
            Console.WriteLine("Car Price: ${0}", price);
            Console.WriteLine("Car Top Speed: {0} MPH", topSpeed);
        }
    }

    internal class Volkswagen : Car
    {
        public int price;
        public int topSpeed;
        public Volkswagen(string name, string brand, int price, int topSpeed) : base(name, brand)
        {
            this.price = price;
            this.topSpeed = topSpeed;
        }

        public void VWCarDetails()
        {
            Console.WriteLine("Car Name: {0}", name);
            Console.WriteLine("Car Brand: {0}", brand);
            Console.WriteLine("Car Price: ${0}", price);
            Console.WriteLine("Car Top Speed: {0} MPH", topSpeed);
        }
    }
}
