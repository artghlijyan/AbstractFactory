using System;

namespace AbstractFactory
{
    abstract class PhoneFactory // AbstractFactory
    {
        public abstract Screen CreateScreen();
        public abstract Processor CreateProcessor();
    }
}
