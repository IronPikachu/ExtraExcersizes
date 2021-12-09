using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wtf
{
    internal class A : IPrint
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }

    internal class B : A
    {
        public new virtual void Print()
        {
            Console.WriteLine("B");
            base.Print();

            var x = this.GetType().GetMethod(nameof(Print));
            x.Invoke(this, null);

         
        }
       
    }

    internal class C : B
    {
        public override void Print()
        {
            Console.WriteLine("C");
        }
    }
}
