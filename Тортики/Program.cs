
namespace ТОРТИКИУАШОТИКА
{
    internal class Program
    {
        static string offer = "";
        static int cashplat = 0;
        static void Main()
        {
            while (true)
            {

                Console.WriteLine("Заказ тортов в магазине У АШОТИКА! ");
                Console.WriteLine("Выберите параметр торта");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("  Форма торта");
                Console.WriteLine("  Размер торта");
                Console.WriteLine("  Вкус коржей");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine($"Вы выбрали {offer}");
                Console.WriteLine($"Цена всего заказа равна:{cashplat}");
                int pos = Tortikimen.Pokaz(3, 9);

                switch (pos)
                {
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Выберите");
                        Console.WriteLine("Параметры:");
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine("  Квадрат - 500");
                        Console.WriteLine("  Круг -- 300");
                        Console.WriteLine("  Сердечко -- 200");
                        Console.WriteLine("  Прямоугольник -- 340");
                        ConsoleKeyInfo key1 = Console.ReadKey();
                        if (key1.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            
                        }
                        pos = Tortikimen.Pokaz(3, 6);
                        switch (pos)
                        {
                            case 3:
                                Console.Clear();
                                cashplat += 500;
                                offer = offer + " Квадрат - 500";
                                
                                break;
                            case 4:
                                Console.Clear();
                                cashplat += 300;
                                offer = offer + " Круг -- 300";
                                
                                break;
                            case 5:
                                Console.Clear();
                                cashplat += 200;
                                offer = offer + " Сердечко -- 200";
                                
                                break;
                            case 6:
                                Console.Clear();
                                cashplat += 340;
                                offer = offer + " Прямоугольник -- 340";
                                
                                break;

                        }
                        break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Выберите");
                            Console.WriteLine("Параметры:");
                            Console.WriteLine("---------------------------------------------------------------------------------------------");
                            Console.WriteLine("  Маленький (Диаметр - 16 см, 8 порций) - 1000");
                            Console.WriteLine("  Обычный (Диаметр - 18 см, 10 порций) - 1200");
                            Console.WriteLine("  Большой (Диаметр - 28 см, 24 порции) - 2000");
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            if (key2.Key ==ConsoleKey.Escape)
                            {
                                Console.Clear();
                                
                            }
                            pos = Tortikimen.Pokaz(3, 5);
                            switch (pos)
                            {
                                case 3:
                                    Console.Clear();
                                    cashplat += 1000;
                                    offer = offer + "Маленький (Диаметр - 16 см, 8 порций) - 1000";
                                    
                                    break;
                                case 4:
                                    Console.Clear();
                                    cashplat += 1200;
                                    offer = offer + "Обычный (Диаметр - 18 см, 10 порций) - 1200";
                                    
                                    break;
                                case 5:
                                    Console.Clear();
                                    cashplat += 2000;
                                    offer = offer + "Большой (Диаметр - 28 см, 24 порции) - 2000";
                                   
                                    break;
                            }
                        break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Выберите");
                            Console.WriteLine("Параметры:");
                            Console.WriteLine("---------------------------------------------------------------------------------------------");
                            Console.WriteLine("  Ванильный - 100");
                            Console.WriteLine("  Шоколадный - 100");
                            Console.WriteLine("  Карамельный - 150");
                            Console.WriteLine("  Ягодный - 200");
                            Console.WriteLine("  Кокосовый - 250");
                            ConsoleKeyInfo key3 = Console.ReadKey();
                            if (key3.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                
                            }
                            pos = Tortikimen.Pokaz(3, 7);
                            switch (pos)
                            {
                                case 3:
                                    Console.Clear();
                                    cashplat += 100;
                                    offer = offer + "Ванильный - 100";
                                    
                                    break;
                                case 4:
                                    Console.Clear();
                                    cashplat += 100;
                                    offer = offer + "Шоколадный - 100";
                                    
                                    break;
                                case 5:
                                    Console.Clear();
                                    cashplat += 150;
                                    offer = offer + "Карамельный - 150";
                                    
                                    break;
                                case 6:
                                    Console.Clear();
                                    cashplat += 200;
                                    offer = offer + "Ягодный - 200";
                                   
                                    break;
                                case 7:
                                    Console.Clear();
                                    cashplat += 250;
                                    offer = offer + "Кокосовый - 250";
                                    
                                    break;
                            }
                            break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Выберите");
                        Console.WriteLine("Параметры:");
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine("  1 корж - 200");
                        Console.WriteLine("  2 коржа - 400");
                        Console.WriteLine("  3 коржа - 600");
                        Console.WriteLine("  4 коржа - 800");
                        ConsoleKeyInfo key4 = Console.ReadKey();
                        if (key4.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            
                        }
                        pos = Tortikimen.Pokaz(3, 5);
                        switch (pos)
                        {
                            case 3:
                                Console.Clear();
                                cashplat += 200;
                                offer = offer + "1 корж - 200";
                                
                                break;
                            case 4:
                                Console.Clear();
                                cashplat += 400;
                                offer = offer + "2 коржа - 400";
                                
                                break;
                            case 5:
                                Console.Clear();
                                cashplat += 600;
                                offer = offer + "3 коржа - 600";
                                
                                break;
                            case 6:
                                Console.Clear();
                                cashplat += 800;
                                offer = offer + "4 коржа - 800";
                                
                                break;
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Выберите");
                        Console.WriteLine("Параметры:");
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine("  Шоколад - 100");
                        Console.WriteLine("  Крем - 100");
                        Console.WriteLine("  Бизе - 150");
                        Console.WriteLine("  Драже -150");
                        Console.WriteLine("  Ягоды - 200");
                        Console.WriteLine("  Шоколадная - 150");
                        Console.WriteLine("  Ягодная - 150");
                        Console.WriteLine("  Кремовая - 150");
                        ConsoleKeyInfo key5 = Console.ReadKey();
                        if (key5.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            
                        }
                        pos = Tortikimen.Pokaz(3, 10);
                        switch (pos)
                        {
                            case 3:
                                Console.Clear();
                                cashplat += 100;
                                offer = offer + "Шоколад - 100";
                               
                                break;
                            case 4:
                                Console.Clear();
                                cashplat += 100;
                                offer = offer + "Крем - 100";
                                Main();
                                break;
                            case 5:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Бизе - 150";
                              
                                break;
                            case 6:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Драже -150";
                                
                                break;
                            case 7:
                                Console.Clear();
                                cashplat += 200;
                                offer = offer + "Ягоды - 200";
                               
                                break;
                            case 8:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Шоколадная - 150";
                                
                                break;
                            case 9:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Ягодная - 150";
                                
                                break;
                            case 10:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Кремовая - 150";
                                
                                break;
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Выберите");
                        Console.WriteLine("Параметры:");
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine("  Шоколадyная - 150");
                        Console.WriteLine("  Ягодная - 150");
                        Console.WriteLine("  Кремовая - 150");
                        ConsoleKeyInfo key6 = Console.ReadKey();
                        if (key6.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            
                        }
                        pos = Tortikimen.Pokaz(3, 10);
                        switch (pos)
                        {
                            case 3:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Шоколад - 150";
                                
                                break;
                            case 4:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Ягодная - 150";
                                
                                break;
                            case 5:
                                Console.Clear();
                                cashplat += 150;
                                offer = offer + "Кремовая - 150";
                               
                                break;
                        }
                        break;
                    case 9:
                        Console.Clear();
                        File.AppendAllText("/Users/levonbabaan/Library/Mobile Documents/com~apple~TextEdit/Documents/Заказ.txt", "\n Заказ от " + DateTime.Now);
                        File.AppendAllText("/Users/levonbabaan/Library/Mobile Documents/com~apple~TextEdit/Documents/Заказ.txt", $"\n Заказ: {offer}");
                        File.AppendAllText("/Users/levonbabaan/Library/Mobile Documents/com~apple~TextEdit/Documents/Заказ.txt", $"\n Цена: {cashplat}");
                        break;
                }

                
            }
        }
    }
}

