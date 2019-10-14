using System;

/*This lab 3 is a class on Television */
namespace CSharpClass.Lab3
{
    public abstract class Television
    {
        public int Size { get; private set; }
        public decimal Price { get; private set; }
        public int Ports { get; private set; }
        public bool IsMountable { get; private set; }

        public Television(int size, decimal price, int ports, bool isMountable)
        {
            Size = size;
            Price = price;
            Ports = ports;
            IsMountable = isMountable;
        }
        public abstract void TurnOn();


    }
}