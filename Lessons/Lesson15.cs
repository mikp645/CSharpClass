using System;

/*This class goes over Lesson 15 content
Enums, Indexers & More */
namespace CSharpClass.Lessons
{
    public class Lesson15
    { 
        public const float pi = 3.14f;
        public const string words = "Happy Coding";


       public enum IceCreamFlavor : byte {Vanilla = 10, Chocolate,
       Strawberry, RockyRoad };

       protected int[]coneSizes = new int[] {5, 10, 15, 20,};

       public int ConeArrayLength { get { return coneSizes.Length; } }

       public int this[int index]
       {
           get {return coneSizes[index]; }
           set { coneSizes[index] = value; }
       } 

       public void CheckExternalEnum()
       {
           int value = (int)Lesson15Enum.Wed;
           Console.WriteLine(Lesson15Enum.Wed +""+value);
       } 
       public void MyFavoriteFlavor(IceCreamFlavor flavor)
       {
           string message = "My favorite flavor is ";
           switch (flavor)
           {
               case IceCreamFlavor.Vanilla:
               message += IceCreamFlavor.Vanilla;
               break;
               case IceCreamFlavor.Chocolate:
               message += IceCreamFlavor.Chocolate;
               break;
               case IceCreamFlavor.Strawberry:
               message += IceCreamFlavor.Strawberry;
               break;
               default:
               case IceCreamFlavor.RockyRoad:
               message += IceCreamFlavor.RockyRoad;
               break;
               
           }
           Console.WriteLine(message);
       }
    }
}