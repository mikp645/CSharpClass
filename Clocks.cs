using System;

/* This class is a child class of Radio
*/

namespace CSharpClass
{
    public class Clocks : Radio
    {
        string _Alarm;
        public void Settings()
        {

        }
        public void ClassicRock()
        {
            Console.WriteLine("Rocks");
        }
        public override void RadioVolumeHalfSpeed()
        {
            Console.WriteLine("Rocks");
        }// end method RadioVolumeHalfSpeed

    }
    
        
    
}