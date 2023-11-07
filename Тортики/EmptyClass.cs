internal class Tortikimen
{
    private int minStrelochka;
    private int maxStrelochka;

    public Tortikimen(int min, int max)
    {
        minStrelochka = min;
        maxStrelochka = max;
    }

    public static int Pokaz(int minStrelochka, int maxStrelochka)
    {
        int pos = 3;
        ConsoleKeyInfo key;

        do
        {
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key = Console.ReadKey();

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && pos != minStrelochka)

                pos--;

            else if (key.Key == ConsoleKey.DownArrow && pos != maxStrelochka)

                pos++;

        } while (key.Key != ConsoleKey.Enter);
        return pos;
    }
}
        