using System;


namespace CSharpClass
{
    public class Sandles : Shoes
    {
        // string _Buckles
        //string _Straps;
        public string Straps { get; set;}

        public string Buckles { get; set;}

        public void Protects()
        {
        }
        public override void Warn()

        {
            Console.WriteLine("The Sandals are Warn for Protection");
        }


    } //end class
} //end namespace