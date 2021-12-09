using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExcersizes;

public class Person
{
    //Fields
    private string name;
    protected int age;

    //Propertys
    public string Name
    {
        get { return name; }
        private set
        {
            if (value.Length < 3)
                throw new ArgumentException($"Name's length should not be less than 3 symbols!");
            name = value;
        }
    }
    public virtual int Age
    {
        get { return age; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException($"Age must be positive!");
            age = value;
        }
    }

    //Constructor
    public Person(string name, int age)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException($"Name was null or empty.");
        }
        Name = name;
        Age = age;
    }

    //Methods
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(string.Format("Name: {0}, Age: {1}", this.Name, this.Age));

        return sb.ToString();
    }
}

