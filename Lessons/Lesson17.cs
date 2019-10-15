using System;

/*This class goes over Lesson 17 content,
Delegates and Lambda */

namespace CSharpClass.Lessons
{
    public class Lesson17
    {
        public string HatType {get; private set;}  
        public int HatSize {get; private set;}
        public string MyResult {get; private set;}

        private string _prop;
        public string MyProperty
        {
            // (paremeters) => expression-or-statement-block
            get => _prop;
            set => _prop = value;
        }

        public delegate void TryOnAnotherHat(string hat);
        public delegate string TryFavoriteHat(string fav);
        delegate int del(int beta); 

        public event TryFavoriteHat MyEventHat;     

        public Lesson17()
        {
            TryOnAnotherHat otherHat = TryOnHat;
            TryALargerHat("fadora", 7, otherHat);
        }
        public Lesson17 (string type, int size)
        {
            HatType = type;
            HatSize = size;
        }

        public Lesson17(string type)
        {
            MyEventHat += new TryFavoriteHat(this.MyFavoriteHat);
            MyResult = MyEventHat(type);
        }

        public string MyFavoriteHat(string message)
        {
            return "My favorite hat is " + message;
        }

public void TryALargerHat(string type, int oldSize, TryOnAnotherHat another)
{
    another("I tried on a " + type + " hat at size "+ (++oldSize));
}
        public void TryOnHat (string message)
        {
            Console.WriteLine(message);
        }
        public int MyLambdaExample(int value)
        {
            // (paremeters) => expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(value);
        }
    }
}