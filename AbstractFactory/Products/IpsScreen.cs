using System;

namespace AbstractFactory
{
    class IpsScreen : Screen
    {
        public IpsScreen()
        {
            ScreenSize = 6;
            Console.WriteLine(ToString());
        }
        
        public override int ScreenSize { get; }

        public override string ToString()
        {
            return "Screen Size is " + ScreenSize;
        }
    }
}
