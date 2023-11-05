// See https://aka.ms/new-console-template for more information

Console.WriteLine("Press ESC to stop");
Console.WriteLine("Press A to generate Lotto");

do
{
    while (Console.ReadKey(true).Key == ConsoleKey.A)
    {
        Random random = new();

        int[] sixNums = new int[6];

        for (int i = 0; i < sixNums.Length; i++)
        {
            sixNums[i] = random.Next(48) + 1;
        }

        Console.WriteLine(string.Join(", ", sixNums.OrderBy(s => s)));
    }
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);