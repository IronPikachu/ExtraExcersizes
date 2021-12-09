using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExcersizes;

internal class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber { get { return facultyNumber; } private set {
            if (value.Length < 5 || value.Length > 10)
                throw new ArgumentException("Invalid faculty number!");
            facultyNumber = value; 
        } }

    public Student(string fName, string lName, string facultyNumber) : base(fName, lName)
    {
        FacultyNumber = facultyNumber;
    }
    public override string ToString()
    {
        return $"{base.ToString()}Faculty number: {FacultyNumber}\n";
    }
}

