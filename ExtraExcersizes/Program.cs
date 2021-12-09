using ExtraExcersizes;
using ExtraExcersizes.Part4;

/*1*/
void Part1()
{
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    try
    {
        Child child = new Child(name, age);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}
/*2*/
void Part2()
{
    try
    {
        string author = Console.ReadLine();
        string title = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());

        Book book = new Book(author, title, price);
        GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

        Console.WriteLine(book + Environment.NewLine);
        Console.WriteLine(goldenEditionBook);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}
/*3*/
void Part3()
{
    string[] student = Console.ReadLine().Split(' ');
    string[] worker = Console.ReadLine().Split(' ');
    Console.WriteLine();

    try
    {
        Student s = new Student(student[0], student[1], student[2]);
        Worker w = new Worker(worker[0], worker[1], double.Parse(worker[2]), double.Parse(worker[3]));

        Console.WriteLine(s);
        Console.WriteLine(w);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}
/*4*/
void Part4()
{
    int iterations = int.Parse(Console.ReadLine());
    List<Song> songs = new List<Song>();
    List<string> inputs = new List<string>();

    for (int i = 0; i < iterations; i++)
    {
        inputs.Add(Console.ReadLine());
    }

    foreach (var item in inputs)
    {
        string[] input = item.Split(';');
        try
        {
            if(input.Length == 3)
            {
                songs.Add(new Song(input[0], input[1], input[2]));
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    Console.WriteLine($"Songs added: {songs.Count}");

    TimeSpan songTime = new TimeSpan();
    foreach (var item in songs)
    {
        songTime += TimeSpan.Parse(item.Time);
    }

    Console.WriteLine($"Playlist length: {songTime}");
}