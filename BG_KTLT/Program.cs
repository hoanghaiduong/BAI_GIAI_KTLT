using System.Text;

namespace BG_KTLT;

class Program
{
    public static int tableWidth = 73;
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        do
        {
            Console.WriteLine("1. Bai 1");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Bai1();
                    break;
                default:
                    break;
            }
        } while (n != 0);
    }

    static void Bai1()
    {
        var table = new ConsoleTables.ConsoleTable("one", "two", "three");
        var x = new int[] { 1, 2, 3 };

        table.AddRow(x.Cast<object>().ToArray());


        table.Options.NumberAlignment = ConsoleTables.Alignment.Right;
        Console.WriteLine(table.ToMinimalString());
    }
}
