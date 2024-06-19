class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Drücke 2 mal eine Taste so schnell hintereinander wie du kannst");
        Console.ReadKey();
        var start = DateTime.Now;
        Console.ReadKey();
        var end = DateTime.Now;
        var time = end - start;
        Console.WriteLine($"\nDu brauchtest {time.TotalMilliseconds} millisekunden");
    }
}