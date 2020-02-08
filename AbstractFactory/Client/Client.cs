using System;

namespace AbstractFactory
{
    class Client
    {
        Screen scr;
        Processor prc;

        public Client(PhoneFactory mobFac)
        {
            scr = mobFac.CreateScreen();
            prc = mobFac.CreateProcessor();
        }

        public override string ToString()
        {
            return scr.ToString() + prc.ToString();
        }

        public void Run()
        {
            this.ToString();
        }
    }
}
