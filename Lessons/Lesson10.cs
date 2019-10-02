using System;

/*This class goes over Lesson 10 content
Lesson 10 - Access modifiers */
namespace CSharpClass.Lessons
{
    public class Lesson10
    {
        // This method shows the private modifier
        private void BasicMethod()
        {
            Console.WriteLine("This is from a private method");
        } // end method basic method

        // This method shows the public modifier
        public void BasicPublicMethod()
        {
            // Will access the private method above
            BasicMethod();
            // The next action is to change a value from lesson 5
            Lesson5 myLesson5 = new Lesson5();
            myLesson5._myLongValue = 985632741L;
            Console.WriteLine("This value {0} is from lesson 5 internal modifier",
            myLesson5._myLongValue);

        } // end basic public method 

    } // end class
} // end namespace