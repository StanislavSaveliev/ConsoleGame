namespace Git_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool DisplayMenu = true;
            while (DisplayMenu)
            {
                DisplayMenu = MainMenu();
            }

        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Разложите числа");
            Console.WriteLine("2) Угадай число");
            Console.WriteLine("3) Выйти");

            string number = Console.ReadLine();

            if (number == "1")
            {
                PrintNumber();
                return true;
            }
            else if (number == "2")
            {
                GueseNumber();
                return true;
            }

            else if (number == "3")
            {
                return false;
            }

            else
            {
                return true;
            }

            static void PrintNumber()
            {
                Console.Clear();
                Console.WriteLine("Игра разложите число");
                Console.WriteLine("Введите число");

                int Readnum = int.Parse(Console.ReadLine());
                int count = 1;

                while (count <= Readnum)
                {
                    Console.Write(count);
                    Console.Write("-");
                    count++;
                }
                Console.WriteLine();
                Console.ReadLine();
            }

            static void GueseNumber()
            {
                Console.Clear();
                Console.WriteLine("Игра угадай число");

                Random myRandom = new Random();

                int randomNumber = myRandom.Next(1, 11);
                int count = 0;

                bool incorrect = true;
                do
                {
                    Console.WriteLine("Отгадай число от 1 до 10");
                    string result = Console.ReadLine();
                    count++;
                    if (result == randomNumber.ToString())
                    {
                        incorrect = false;
                    }
                    else
                        Console.WriteLine("Ты не угадал число попробуй еще раз!");

                } while (incorrect);
                Console.WriteLine("Молодец, ты угадал число! Тебе потребовалось {0} попыток", count);

                Console.ReadLine();

            }
        }
    }
}
