namespace C_SharpDev_MOD2_HW
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            string FullName;
            byte Age;
            string Email;
            float Rating_ComScience;
            float Rating_Math;
            float Rating_Physics;
            float Rating_summa;
            float Rating_mean;
            string pattern = "Ф.И.О: {0} \nВозраст: {1} \nEmail: {2}" +
                " \nБалл по программированию: {3}" +
                " \nБалл по математике: {4}" +
                " \nБалл по физике: {5}";


            // Студент 1. Петров.

            Console.WriteLine("Студент 1");
            Console.WriteLine("Задание 1. Создание переменных и вывод.");

            FullName = "Петров Петр Петрович"; Age = 18; Email = "petrov@email.com";
            Rating_ComScience = 4; Rating_Math = 4; Rating_Physics = 3;
            
            Console.WriteLine("\n" + pattern, FullName, Age, Email, Rating_ComScience, Rating_Math, Rating_Physics);
            Console.Write("\nНажмите любую клавишу для перехода к ответам по заданию 2...\n");
            Console.ReadKey();

            Rating_summa = Rating_ComScience + Rating_Math + Rating_Physics;
            Rating_mean = (Rating_ComScience + Rating_Math + Rating_Physics) / 3;

            Console.WriteLine("\nЗадание 2. Подсчет баллов.");

            Console.WriteLine($"\nСумма баллов: {Rating_summa}");
            Console.ReadKey();
            Console.WriteLine($"Cреднее арифметическое баллов: {Rating_mean.ToString("#.##")}");
            Console.Write("\nНажмите любую клавишу для перехода к информации по студенту 2...\n");
            Console.ReadKey();
            Console.WriteLine();

            // Студент 2. Андреева.

            Console.WriteLine("Студент 2");
            Console.WriteLine("Задание 1. Создание переменных и вывод.");

            FullName = "Андреева Анна Андреевна"; Email = "anna@email.ru";
            Rating_ComScience = 5; Rating_Math = 5; Rating_Physics = 4;

            Console.WriteLine("\n" + pattern, FullName, Age, Email, Rating_ComScience, Rating_Math, Rating_Physics);
            Console.Write("\nНажмите любую клавишу для перехода к ответам по заданию 2...\n");
            Console.ReadKey();

            Rating_summa = Rating_ComScience + Rating_Math + Rating_Physics;
            Rating_mean = (Rating_ComScience + Rating_Math + Rating_Physics) / 3;

            Console.WriteLine("\nЗадание 2. Подсчет баллов.");

            Console.WriteLine($"\nСумма баллов: {Rating_summa}");
            Console.ReadKey();
            Console.WriteLine($"Cреднее арифметическое баллов: {Rating_mean.ToString("#.##")}");
            Console.ReadKey();
        }
    }
}