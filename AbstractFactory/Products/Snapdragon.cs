using System;

namespace AbstractFactory
{
    class Snapdragon : Processor
    {
        public Snapdragon()
        {
            Name = "SNAPDRAGON 856";
            Console.WriteLine(ToString());
        }

        public override string Name { get; } 

        public override string ToString()
        {
            return "Processor is " + Name;
        }
    }
}
