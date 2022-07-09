using System.Diagnostics;

namespace ProgrammingLanguageThrowdown;
class Program
{
    static void Main()
    {
        int reps = 100;
        long cs = 0, cpp = 0, js = 0, py = 0;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Starting C#");
        Parallel.For(0, reps, i =>
        {
            cs += Run("CSharp");
        });
        cs /= reps;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Starting C++");
        Parallel.For(0, reps, i =>
        {
            cpp += Run("C++");
        });
        cpp /= reps;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Starting NodeJS");
        Parallel.For(0, reps, i =>
        {
            js += Run("NodeJS");
        });
        js /= reps;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Starting Python");
        Parallel.For(0, reps, i =>
        {
            py += Run("Python");
        });
        py /= reps;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("-----------------------RESULTS-----------------------");
        Console.WriteLine($"C# took average of {cs} Ticks or {TimeSpan.FromTicks(cs).TotalMilliseconds}ms");
        Console.WriteLine($"C++ took average of {cpp} Ticks or {TimeSpan.FromTicks(cpp).TotalMilliseconds}ms");
        Console.WriteLine($"NodeJS took average of {js} Ticks or {TimeSpan.FromTicks(js).TotalMilliseconds}ms");
        Console.WriteLine($"Python took average of {py} Ticks or {TimeSpan.FromTicks(py).TotalMilliseconds}ms");
        Console.Write("Press Any Key to Continue...");
        Console.ReadKey();
    }

    static long Run(string lang)
    {
        long startTime = DateTime.Now.Ticks;
        Process process = new()
        {
            StartInfo = new()
            {
                FileName = Path.GetFullPath($".\\lang\\{lang}.exe"),
                UseShellExecute = false
            }
        };
        process.Start();
        process.WaitForExit();
        return DateTime.Now.Ticks - startTime;
    }
}