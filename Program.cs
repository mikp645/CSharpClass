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
            // MyLesson6Examples();
            // MyLesson7Examples();
            // MyLesson8Examples();
            // MyOtherLesson8Examples();
           // MyLesson9Examples();
           MyLesson10Examples();
        } // End Method Main 

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10();
            myTen.BasicPublicMethod();
            Lesson5 myFive = new Lesson5();
            myFive._myLongValue = 12345L; //can see because its internal 

        } // end method my lesson 10 examples

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArraySample();
            myNine.My3DArrayExample();
            myNine.MyJaggedArrayExample();

        } // end method my lesson 9 examples

        static void MyOtherLesson8Example()
        {
            Lesson8 myLesson8 = new Lesson8();
            myLesson8.BasicWhileLoop();

            myLesson8.BasicDoWhileLoopExample();
            myLesson8.BasicForLoopExample(5);
            myLesson8.BasicForEachLoopExample();
            Console.WriteLine(myLesson8.BasicJumpStatementExample("Sunday"));
            myLesson8.BasicOtherJumpStatements();

        } // end method my other lesson 8 examples


        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseExample();
            myEight.BasicIfElseExample();
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrConditionExample(4));
            myEight.BasicTernaryOperatorExample(42);
            myEight.BasicSwitchExample(3);


        } // end method my lesson 8 examples

        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.MyCheckOperator1();
            mySeven.MyCheckOperator2();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator();
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXOrAssignmentOperator();
            mySeven.MyIncrementDecrementExample();
        }  // end method my lesson 7 examples

        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            string myJoined = mySix.MyJoinedStrings("Happy", "Coding");
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
