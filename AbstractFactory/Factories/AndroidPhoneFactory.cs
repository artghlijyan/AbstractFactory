using System;

namespace AbstractFactory
{
    class AndroidPhoneFactory : PhoneFactory
    {
        public override Processor CreateProcessor()
        {
            return new Snapdragon();
        }

        public override Screen CreateScreen()
        {
            return new IpsScreen();
        }
    }
}
