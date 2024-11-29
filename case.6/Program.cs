using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());
        double L = double.Parse(Console.ReadLine());

        double metr = 0;
        bool isValid = true;

        switch (N)
        {
            case 1: 
                metr = L * 0.1;
                break;
            case 2: // Километры
                metr = L * 1000;
                break;
            case 3: // Метры
                metr = L;
                break;
            case 4: // Миллиметры
                metr = L * 0.001;
                break;
            case 5: // Сантиметры
                metr = L * 0.01;
                break;
            default: // Некорректный номер единицы
                isValid = false;
                Console.WriteLine("Ошибка: номер единицы длины должен быть в диапазоне 1-5.");
                break;
        }

        
        if (isValid)
        {
            Console.WriteLine($"Darozi bo metr: {metr}");
        }
    }
}