using System;

namespace Lab13
{
    class Program
    {
        static void Main()
        {
            // 1. Создаём объект класса Box
            Box box = new Box();

            // 2. Задаём значения полям объекта
            box.Width = 2;    // ширина
            box.Height = 3;   // высота
            box.Length = 5;   // длина

            // 3. Выводим данные, хранящиеся в объекте
            box.Show();

            // 4. Рассчитываем объём и выводим на экран
            float v = box.Volume();
            Console.WriteLine($"Объём коробки = {v}");

            Console.ReadKey();
        }
    }

    class Box
    {
        // Открытые поля для хранения размеров коробки
        public float Height;
        public float Width;
        public float Length;

        // Метод — показать данные о ящике
        public void Show()
        {
            Console.WriteLine("Данные о коробке:");
            Console.WriteLine($"  Ширина = {Width}");
            Console.WriteLine($"  Высота = {Height}");
            Console.WriteLine($"  Длина  = {Length}");
        }

        // Метод — рассчитать объём коробки
        public float Volume()
        {
            return Width * Height * Length;
        }
    }
}