using System;

namespace CSharpClass
{
    /*This class demonstrates the basic object of house
    Lesson 4 - My Application Overview */
    public class House
    {
        int _windowSize;
        string _foundation;
        //string _roofType;
        //string _doorColor;

        public int WindowSize
        {
            get { return _windowSize; }
            set { _windowSize = value; }
        }
        public string Foundation
        {
            get {return _foundation;}
            set {_foundation = value;}
        }

        public string RoofType { get; set;}

        public string DoorColor {get; private set;}

        public House () 
            : this(24, "slate")
         {}

        public House (int windowSize, string foundation)
        : this (windowSize, foundation, "shingle", "green")
        {

        }

        public House (int windowSize, string foundation, string roofType,string doorColor) 
        {
            this._windowSize = windowSize;
            this._foundation = foundation;
            RoofType = roofType;
            DoorColor = doorColor;
        }

        public virtual void DoorOpenClose()
        {
            Console.WriteLine("The door opens");
            this.DoorOpenClose("blue");
        } //end method door open close

        public void DoorOpenClose(string doorColor)
        {
            Console.WriteLine("My door is {0}", doorColor);
        }

    }//end class
}//end namespace