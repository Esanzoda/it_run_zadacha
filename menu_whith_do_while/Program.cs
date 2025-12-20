using System;

class Program
{
    static void Main()
    {
      
        string[] desert = { "Kis", "Fit" };
        string[] sup = { "Kharcho", "Khomshurbo" };
        int[] desertPrice = { 15, 12 };
        int[] supPrice = { 30, 25 };

        int choice;
        double total = 0;

        do
        {
            Console.WriteLine(" МЕНЮ РЕСТОРАНА");
            Console.WriteLine("1  Супы");
            Console.WriteLine("2  Десерты");
            Console.WriteLine("0  Выход");
            Console.Write("Выберите категорию: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: // Супы
                    Console.WriteLine("\n СУПЫ:");
                    for (int i = 0; i < sup.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {sup[i]} - {supPrice[i]} сомони");
                    }

                    Console.Write("Выберите суп (номер): ");
                    int supChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (supChoice >= 0 && supChoice < sup.Length)
                    {
                        total += supPrice[supChoice];
                        Console.WriteLine($"{sup[supChoice]} добавлен в заказ.");
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор!");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n ДЕСЕРТЫ:");
                    for (int i = 0; i < desert.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {desert[i]} - {desertPrice[i]} сомони");
                    }

                    Console.Write("Выберите десерт (номер): ");
                    int desertChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (desertChoice >= 0 && desertChoice < desert.Length)
                    {
                        total += desertPrice[desertChoice];
                        Console.WriteLine($"{desert[desertChoice]} добавлен в заказ.");
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор!");
                    }
                    break;

                case 0:
                    Console.WriteLine("Заказ завершён.");
                    break;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Текущая сумма: " + total + " сомони");

        } while (choice != 0);

        Console.WriteLine("\n Итог к оплате: " + total + " сомони");
    }
}
