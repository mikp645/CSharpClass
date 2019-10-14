using System;

/*This class is a child of Television */
namespace CSharpClass.Lab3
{

    public class HDTelevision : Television

    {
        public override void TurnOn()
        {
            Console.WriteLine("turn on with remote");
        }
        public HDTelevision(int size, decimal price, int ports, bool isMountable)
        : base(size, price, ports, isMountable)
        { }



        public HDTelevision(int size, decimal price)
       : this(size, price, 4, false)
        {

        }

    }

}