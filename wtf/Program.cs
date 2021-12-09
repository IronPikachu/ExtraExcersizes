using wtf;

List<IPrint> prints = new List<IPrint> ();

prints.Add (new A());
prints.Add (new B());
prints.Add (new C());
prints.Add(new A());
prints.Add(new B());
prints.Add(new C());
prints.Add(new A());
prints.Add(new B());
prints.Add(new C());
prints.Add(new A());
prints.Add(new B());
prints.Add(new C());
prints.Add(new A());
prints.Add(new B());
prints.Add(new C());

foreach (var item in prints)
{
    item.Print();
    if(item is A)
    {
        Console.WriteLine("Item is A");
    }
    if(item is B)
    {
        Console.WriteLine("Item is B");
        ((B)item).Print();
    }
    if (item is C)
    {
        Console.WriteLine("Item is C");
    }
    if(item is IPrint)
    {
        Console.WriteLine("Item is IPrint");
    }
}

((C)prints[2]).Print();

C? c = prints[2] as C;
c.Print();
c.Print();

if(c is IPrint)
{
    Console.WriteLine("C is IPrint");
}



string p = "12";
int i = 12;

if(p is int)
    Console.WriteLine("ye");

