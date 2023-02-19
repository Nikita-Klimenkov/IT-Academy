using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
              Task1();
             
              Task2();
             
              Task3();
             
              Task4();
        }

        private static void Task1()
        {
            Console.WriteLine("Задание номер 1");
            
            int[] firstArray = { 5, 7, 1, 4, 12, 9};
            
            Console.WriteLine("Неотсортированный массив: ");
            PrepareArray(firstArray);
            
            Console.ReadKey();
            
            Console.WriteLine("\nОтсортированный массив:");
            
            Array.Sort(firstArray);
            Array.Reverse(firstArray);
            
            Console.WriteLine("Первый способ");

            PrepareArray(firstArray);

            Console.ReadKey();
            
            Console.WriteLine("\nВторой способ");

            Array.Reverse(firstArray);
            
            for (int i = firstArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{firstArray[i]} ");
            }
            
            Console.WriteLine("\nПоследние 3 элемента");

            for (int i = 1; i <= 3 ; i++)
            {
                Console.Write($"{firstArray[^i]} ");
            }

            Console.WriteLine("\nЧетные элементы, которые больше 5");
            
            foreach (var number in firstArray)
            {
                if (number % 2 == 0 && number > 5)
                {
                    Console.Write($"{number} ");
                }
            }
            
            Console.WriteLine("\nНажмите на любую клавишу для следующего задания:");
            Console.ReadKey();
            Console.Clear();
        }
        
        private static void Task2()
        {
            Console.WriteLine("Задание номер 2");

            int[,] secondArray = { {74,19,77}, {70,79,36}, {88,21,43} };
            
            int maxValue = 0;

            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    if (secondArray[i, j] > maxValue)
                    {
                        maxValue = secondArray[i, j];
                    }
                }
                
                Console.WriteLine($"{i + 1} Ряд = {maxValue}");
            }
            
            Console.WriteLine("Нажмите на любую клавишу для следующего задания:");
            Console.ReadKey();
            Console.Clear();
        }
        
        private static void Task3()
        {
            Console.WriteLine("Задание номер 3");
            
            string way = @"c:\WebServers\home\testsite\www\myfile.txt";

            way = way.Replace(".", "\\");
            
            string[] words = way.Split("\\");
            
            Console.WriteLine($"Имя файла равно - {words[^2]}");
            
            Console.WriteLine("Нажмите на любую клавишу для следующего задания:");
            Console.ReadKey();
            Console.Clear();
        }
        
        private static void Task4()
        {
            Console.WriteLine("Задание номер 4");
            
            string text = "Забавная история о мальчике, который не хотел есть манную кашу.\n" +
                          "Мама пообещала сводить его в Кремль, если он съест всю кашу.\n" +
                          "Дениска добавляет в кашу сахар, соль, воду и даже хрен, чтобы сделать ее более вкусной.\n" +
                          "Но ничего не помогает, и он решает выбросить кашу в окно.\n" +
                          "Мама довольна, что сын все съел.\n" +
                          "Однако через некоторое время к ним приходит милиционер с гражданином, облитым кашей из окна.";

            Console.WriteLine($"Текст для выполнения задания: \n{text}");
            
            Regex regex = new Regex(@"\w+");
            MatchCollection matchCollection = regex.Matches(text);
            
            Console.WriteLine($"Количество слов в тексте равно - {matchCollection.Count} слов");
        }

        private static void PrepareArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}