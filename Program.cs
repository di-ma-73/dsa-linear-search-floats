using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSerachFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random((int)DateTimeOffset.Now.ToUnixTimeMilliseconds());
            float[] secretNumbers = new float[16];

            Console.WriteLine($"ℹ️ Генерируем {secretNumbers.Length} случайных дробных числа...");
            for (int i = 0; i < secretNumbers.Length; ++i)
            {
                // ...
                // ... Каждое число должно быть случайным и иметь дробную часть не менее чем из трёх знаков после запятой
                // ...
            }

            Console.WriteLine($"ℹ️ Числа в массиве: ");
            // ...
            // ... Должно вывести все числа в одну строку через пробел...
            // ...

            Console.Write($"ℹ️ Введите число для поиска: ");
            float searchNumber = float.NaN; // Здесь должен быть ввод дробного числа пользователем из консоли
            Console.Write($"ℹ️ Введите тип поиска: ");
            // ...
            // ... Здесь нужно выполнить выбранный пользователем тип поиска (вызывать LinearSearchByValue(...) с соответствующими аргументами)
            // ... В зависимости от результата поиска вывести сообщение с индексом найденного числа
            // ...
            Console.ReadKey();
        }
        
        static int LinearSearchByValue(float[] array, float value, bool fromEnd = false)
        {
            // ...
            // ... Реализуйте последовательный поиск значения [value] в массиве [array], учитывая параметр [fromEnd]
            // ... [fromEnd] - признак поиска с конца (если [false] или [не указан], то поиск производится с начала массива)
            // ... Алгоритм должен возвращать индекс числа в массиве. В остальных случаях – минус 1.
            // ...
            return -1;
        }
    }
}
