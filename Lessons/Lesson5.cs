using System;

namespace CSharpClass.Lessons
{ 
    /*This class goes over Value types
    lesson 5 - Value Types */
    public class Lesson5
    {
       // Itegral - signed
       // range -128 - 127
       sbyte _mySByteValue;

       // range -32,768 to 32,767
       short _mySHortValue = 4;

       // range -2,147,483,648 to 2,147,483,647
       int _myIntValue = 25000;

       // range - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
       long _myLongValue = 1234567L;

    // Integral - Unsigned
    // Range 0 - 255
    byte _myByte = 3;

    // range 0 to 65,535
    ushort _myUShortValue = 35;

    // range 0 to 4,294,967,295
    uint _myUInt = 2345U;

    // range 0 to 18,446,744,073,709,551,615
    ulong _myULong = 123456UL;

    // Real Numbers
    // range 3.4E +/- 38 (7digits)
    float _myFloatValue = -123.6589F;

    // range 1.7E +/- 308 (15 digits)
    double _myDoubleValue =12.34D;

    // range -7.9228E+24 to 7.9228E+24
    decimal _myDecimalValue = 13.234M;

    //Integral Literals
    // Decimal value of 26
    int _value = 26;



    //Hexadecimal value of 26
    int _value2 = 0x1a;

    // Binary value of 26
    int _value3 = 0b11010;

    // Notation & Underscores
    double _valNote = 6.26e22;

    // Using _ to seperate numbers
    long _myUnderscoreLong = 1_234_834L;

    double _myUnderscoreDouble = 1_348.4;
    // Casting
    //Explicit cast where fractions are truncated and not rounded
    public void ConvertFloatToInt()
    {
        // local variable
        int converted = (int)_myFloatValue;
        Console.WriteLine(converted);
    } // end method convert float to int
    
 
        //Implicit cast which requires no casting
        public void Longfromint()
        {

                long someLongValue = _myIntValue;
                Console.WriteLine(someLongValue);
        } //end method long from int


    } //End Class
} // End namespace 