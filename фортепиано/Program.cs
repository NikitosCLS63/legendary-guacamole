

internal class Program
{
    static int[] oneOkt = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
    static int[] tooOkt = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
    static int[] testOkt = new int[12];




    static void Main(string[] args)
    {
        Console.WriteLine("ВЫ ВОШЛИ В ПИАНИНО, СЫГРАЙТЕ НАМ ЧТО НИБУДЬ");
        Console.WriteLine("  ");

        Console.WriteLine("F1 и F2  переключение  октав.");
        Console.WriteLine("С d по l  белые , с r по i - чёрные.");
        Console.WriteLine("  ");
        Console.WriteLine("1 октава.");

        testOkt = oneOkt;



        do
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
            {
                Oktava(key);
            }
            Zvuk(key);
        }
        while (true);
    }
    static int[] Oktava(System.ConsoleKeyInfo key)
    {
        string okt = key.Key == ConsoleKey.F1 ? "1 октава" : "2 октава";
        Console.WriteLine(okt);
        testOkt = key.Key == ConsoleKey.F1 ? oneOkt : tooOkt;
        return testOkt;
    }

    static void Zvuk(System.ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.Q:
                Console.Beep(testOkt[0], 300);
                break;
            case ConsoleKey.W:
                Console.Beep(testOkt[2], 300);
                break;
            case ConsoleKey.E:
                Console.Beep(testOkt[4], 300);
                break;
            case ConsoleKey.R:
                Console.Beep(testOkt[5], 300);
                break;
            case ConsoleKey.T:
                Console.Beep(testOkt[7], 300);
                break;
            case ConsoleKey.Y:
                Console.Beep(testOkt[9], 300);
                break;
            case ConsoleKey.U:
                Console.Beep(testOkt[11], 300);
                break;
            case ConsoleKey.A:
                Console.Beep(testOkt[1], 300);
                break;
            case ConsoleKey.S:
                Console.Beep(testOkt[3], 300);
                break;
            case ConsoleKey.D:
                Console.Beep(testOkt[6], 300);
                break;
            case ConsoleKey.F:
                Console.Beep(testOkt[8], 300);
                break;
            case ConsoleKey.G:
                Console.Beep(testOkt[10], 300);
                break;
        }
    }


}
