using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExcersizes;

public class Child : Person
{

    //Propertys
    public override int Age
    {
        get { return age; }
        protected set
        {
            if (value > 15)
                throw new ArgumentException($"Child's cannot be more than 15!");
            base.Age = value;
        }
    }

    //Constructor
    public Child(string name, int age) : base(name, age)
    {

    }
}

