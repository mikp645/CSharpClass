using System;


namespace CSharpClass
{  /*This class shows a radio with 3 attributes */

    public class Radio

    {
        int _speakers;
        string _volume;
        string _tuning;

        public virtual void RadioVolumeHalfSpeed()
        {
            Console.WriteLine("Classic Rock");
        }// end method RadioVolumeHalfSpeed


        public void RadioVolumeHalfSpeed(string _speakers)
        {
        }

    } //end class

} // end namespace 