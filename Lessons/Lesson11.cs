using System;

/* This class goes over the lesson 11 content
Constructors */
namespace CSharpClass.Lessons
{
    public class Lesson11
    {
        public Lesson11(string type, int value)
        {
            Console.WriteLine("This {0} type and {1} value are from a constructor",
            type, value);

        } // end constructor 
        public Lesson11(int value)
{
    Console.WriteLine("This {0} value came from a different constructor",
    value);

} // end constructor 

public Lesson11()
{
    Console.WriteLine("My default constructor");
} // end constructor
    // This method uses the ref keyword
    public void MyBasicRefExample(ref int able)
    {
        able +=6;
        Console.WriteLine(able);
    } // end method my basic ref example

    // This method uses the out keyword
    public void MyBasicOutExample(string name, out string firstname,
     out string lastname)
     {
         int myIndex = name.IndexOf(' ');
            firstname = name.Substring(0, myIndex);
            lastname = name.Substring(myIndex + 1);

     } // end method my basic out example

        

    }// end class
} // end namespace