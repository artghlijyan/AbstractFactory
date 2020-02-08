using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client2 = new Client(new AndroidPhoneFactory());

            client2.Run();
        }
    }
}
