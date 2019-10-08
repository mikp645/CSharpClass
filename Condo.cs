using System;

/* This class is a child class of House
Lesson 12 Inheritance */
namespace CSharpClass
{
    public class Condo: House
    {

       string _balcony;

       public Condo()
       :this("second floor") {   }
 
       public Condo(string balcony)
        : base(32, "concrete")
       {
           Balcony = balcony;
       }

        public string Balcony 
           {
            get { return _balcony; }
            set { _balcony= value; }
        }

       public void Maintenance() {base.DoorOpenClose(); }
       
        

        
       public override void DoorOpenClose()
       {
           base.DoorOpenClose();
           Console.WriteLine("This condo door is closed");
       }
    }
} 