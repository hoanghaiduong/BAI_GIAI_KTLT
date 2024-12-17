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
            Console.WriteLine("---Danh sách bài tập---");
            Console.WriteLine("1. Bai 1");
            Console.Write("Mời bạn chọn bài tập nè: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn chọn bài {0} ", n);
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
