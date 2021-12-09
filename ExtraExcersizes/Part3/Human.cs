using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExcersizes;

internal class Human
{
    //Fields
    private string fName;
    private string lName;

    //Propertys
    public string FName { get { return fName; } private set {
            if (!char.IsUpper(value[0]))
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            if(value.Length < 4)
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            fName = value; 
        } }
    public string LName { get { return lName; } private set {
            if (!char.IsUpper(value[0]))
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            if (value.Length < 3)
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            lName = value; 
        } }

    //Constructor
    public Human(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }

    //Methods
    public override string ToString()
    {
        return $"First name: {FName}\nLast name: {LName}\n";
    }
}

