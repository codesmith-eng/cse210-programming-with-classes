using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the first constructor in the Fraction class
        Fraction f1 = new Fraction();
        f1.GetFractionString();
        f1.GetDecimalValue();

        //creating an instance of the second constructor and passing 0 as a parameter to initiate the second instance because
        //if parameter is not passed in, the second constructor will not be instantiated.
        //NOTE: WE CAN EITHER USE SETTERS OR PARAMETER TO PASS VALUE TO THE _TOP MEMBER VARIABLE IN THE FRACTION CLASS
        Fraction f2 = new Fraction(0);
        f2.SetTop(5); //passing value to the Settop setter that passes the value to the private _top member 
        // variable in Fraction class.This settop setter pass the value  of 5 to the _top member variable 
        f2.GetFractionString();
        f2.GetDecimalValue();

        //creating an instance of the third constructor and passing 0 as a parameters to initiate the third instance because
        //if parameters are not passed in, the third constructor will not be instantiated.
        //NOTE: WE CAN EITHER USE SETTERS, GETTERS OR PARAMETERS TO PASS VALUE TO THE _TOP MEMBER VARIABLES IN THE FRACTION CLASS
        Fraction f3 = new Fraction(0, 0);
        f3.SetTop(3); //Using the SetTop setter in the fraction class to pass value to the _top member 
                      // variable in the fraction class
        f3.SetBottom(4);//Using the SetBottom setter in the fraction class to pass value to the _bottom member 
                        // variable in the fraction class
        f3.GetFractionString();
        f3.GetDecimalValue();


        Fraction f4 = new Fraction(0, 0);
        f4.SetTop(1); //Using the SetTop setter in the fraction class to pass value to the _top member 
                      // variable in the fraction class
        f4.SetBottom(3);//Using the SetBottom setter in the fraction class to pass value to the _bottom member 
                        // variable in the fraction class
        f4.GetFractionString();
        f4.GetDecimalValue();
    }
}