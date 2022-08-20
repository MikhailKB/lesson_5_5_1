using System;
using static System.Console;


namespace lesson_5_5_1

{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param> любой введённый случайный текст
        /// <returns></returns>
        static string[] ArrayCreation(string text) // создание массива
        {
            string[] words = text.Split(' '); // разбивает строку на максимальное число подстрок на основе указанного символа-разделителя
            return words;
        }
        static string[] DataOutput(string[] words) // вывод данных
        {
            for (int i = 0; i < words.Length; i++)
            {
                WriteLine($"{words[i]} ");
            }
            return words;
        }
        static void Main(string[] args)
        {
            WriteLine("Введите любое предложение, разделяя слова пробелами: ");
            string text = ReadLine();
            ArrayCreation(text);
            string[] words = ArrayCreation(text);
            DataOutput(words);
            ReadKey();
        }
    }
}
