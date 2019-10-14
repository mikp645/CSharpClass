using System;

/*This class is an abstract class of Televison */


namespace CSharpClass.Lab3
{
    public class FourKTelevision : Television
    {
       public override void TurnOn()
       {
           Console.WriteLine("turn on with app");
       }
       public FourKTelevision(int size, decimal price, int ports, bool isMountable)
       : base(size, price, ports, isMountable)
       {}
       public FourKTelevision(int size, decimal price)
       :this(50 , 5.50m, 4, true)
       {

       }      
    }



}