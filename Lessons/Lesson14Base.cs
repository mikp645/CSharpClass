using System;

/*This class goes over Lesson 14 content
Abstract */
namespace CSharpClass.Lessons
{
    public abstract class Lesson14Base : ILesson14
    {
      protected double inches = 12, feet = 3, yard = 1760;
      protected int num;

      public abstract void ShowResultFeet(); // abstract method 
      public abstract void ShowResultMiles(); // From Interface ILesson14

      public abstract double FeetToInches {get;} // abstract property
      public abstract double YardsToFeet {get;}
      public abstract double MilesToYards { get;} // From Interface ILesson14

      public Lesson14Base(int num) { this.num = num; }

    }
}