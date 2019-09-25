using System;
using CSharpClass.Lessons;

namespace CSharpClass
{
    /*This class is the start of my application.
    Lesson 3 - My First Application */
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
          // MyLesson5Examples();  
          MyLesson6Examples();        
        } // End Method Main 

        static void MyLesson6Examples()
            {
           Lesson6 mySix = new Lesson6();
           mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            string myJoined = mySix.MyJoinedStrings("Happy","Coding");
            Console.WriteLine(myJoined);
            string myFav = mySix.MyStringBuilder("pizza", 3);
            Console.WriteLine(myFav);
            mySix.MyExampleChar();

            mySix.MyEscapeExample();
            mySix.MyPlaceHolderExample("galaga", "classic");

        } // end method my lesson 6 examples

        static void MyLesson5Examples()
        {
            Lesson5 myfive = new Lesson5();
            myfive.ConvertFloatToInt();
            myfive.Longfromint();
        }// end method my lesson 5 examples
        

        } //End class
} //end namespace
