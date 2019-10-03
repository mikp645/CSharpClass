using System;

/* This class is a child class of House
Lesson 12 Inheritance */
namespace CSharpClass
{
    public class Condo: House
    {
       string _balcony;
       public void Maintenance()
       {

       } 
       public override void DoorOpenClose()
       {
           Console.WriteLine("This condo door is closed");
       }
    }
} 