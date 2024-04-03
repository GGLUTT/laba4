using System;

namespace laba_4
{
    public class Computer
    {
        public string Name { get; set; }
        public string Release { get; set; }
        public string Color { get; set; }

        public virtual void TurnOn()
        {
            Console.WriteLine("Computer is turning on...");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Computer is turning off...");
        }

        public virtual void CheckForViruses()
        {
            Console.WriteLine("Checking for viruses...");
        }
    }

    public class Vinchester : Computer
    {
        public int Storage { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, Release = {Release}, Color = {Color}, Storage = {Storage}, Type = {Type}";
        }
    }

    public class Discovod : Computer
    {
        public int Storage { get; set; }
        public string Materials { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, Release = {Release}, Color = {Color}, Storage = {Storage}, Materials = {Materials}";
        }
    }

    public class RAM : Computer
    {
        public int Storage { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, Release = {Release}, Color = {Color}, Storage = {Storage}, Speed = {Speed}";
        }
    }

    public class Processor : Computer
    {
        public int Storage { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, Release = {Release}, Color = {Color}, Storage = {Storage}, Speed = {Speed}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vinchester vinchester = new Vinchester
            {
                Name = "Example Vinchester",
                Release = "2024",
                Color = "Black",
                Storage = 1000,
                Type = "SSD"
            };

            Discovod discovod = new Discovod
            {
                Name = "Example Discovod",
                Release = "2024",
                Color = "Silver",
                Storage = 500,
                Materials = "Plastic"
            };

            RAM ram = new RAM
            {
                Name = "Example RAM",
                Release = "2024",
                Color = "Green",
                Storage = 16,
                Speed = 3200
            };

            Processor processor = new Processor
            {
                Name = "Example Processor",
                Release = "2024",
                Color = "Gold",
                Storage = 500,
                Speed = 3
            };

            Console.WriteLine("Turning on the computer...");
            Console.WriteLine(vinchester);
            vinchester.TurnOn();
            Console.WriteLine(discovod);
            discovod.TurnOn();
            Console.WriteLine(ram);
            ram.TurnOn();
            Console.WriteLine(processor);
            processor.TurnOn();

            Console.WriteLine("Checking for viruses...");
            vinchester.CheckForViruses();
            discovod.CheckForViruses();
            ram.CheckForViruses();
            processor.CheckForViruses();

            Console.WriteLine("Turning off the computer...");
            vinchester.TurnOff();
            discovod.TurnOff();
            ram.TurnOff();
            processor.TurnOff();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
