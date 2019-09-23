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
           MyLesson5Examples();
        } // End Method Main 

        static void MyLesson5Examples()
        {
            Lesson5 myfive = new Lesson5();
            myfive.ConvertFloatToInt();
            myfive.Longfromint();
        }// end method my lesson 5 examples

        } //End class
} //end namespace
