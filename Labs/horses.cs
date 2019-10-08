using System;


namespace CSharpClass.Labs
{
    public class Horses
    {
       int _hooves;
       string _tail;
       string _mane;
       string _snout;
       public string Tail
        {
            get { return _tail; }
            set { _tail = value; }
        }
        public int Hooves
        {
            get { return _hooves; }
            set { _hooves = value; }
        }
        public string Mane
        {
            get { return _mane; }
            set { _mane = value; }
        }
        public string Snout
        {
            get { return _snout; }
            set { _snout = value; }
        }
        public Horses ()
        :this (4, "gold", "broud","bushy")
        {}
        
        public Horses(int hooves,string mane, string snout, string tail)
        {
            this._hooves = hooves;
            this._mane = mane;
            this._snout = snout;
            this._tail = tail;

        }
        

       public virtual void RunsAndDrinks() 
       {
           
           Console.WriteLine("runs and drinks ");
       }
    }
}