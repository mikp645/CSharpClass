using System;

namespace CSharpClass.Labs
{
    public class Labs2
    {
        public void CheckGrade(char grade)
        {
            switch(grade)
            {
                case 'E':
                Console.WriteLine("Excellent");
                break;
                case 'V':
                Console.WriteLine("Very Good");
                break;
                case 'G':
                Console.WriteLine("Good");
                break;
                case 'A':
                Console.WriteLine("Average");
                break;
                case 'F':
                Console.WriteLine("Fail");
                break;
                default: Console.WriteLine("This is not a valid Grade");
                break;
            }
        }
    }

}