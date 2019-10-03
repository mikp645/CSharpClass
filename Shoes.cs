using System;


namespace CSharpClass
{
    // A simple app describeing shoes

    public class Shoes
    {
       int _Laces;
       string _eyelets;
       string _souls;

       public virtual void Warn() 
       {
           Console.WriteLine("The Shoes are warn");
       } // end method warn

            public  void Warn(string laced) 
       {
           
       } // end method warn

    } //end class
} //end namespace