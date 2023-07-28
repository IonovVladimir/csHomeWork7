using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        
        void FillArrayDouble(double[,] array,int minValue=0, int maxValue=1)                  
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    array[i, j] = rnd.NextDouble()*rnd.Next(minValue,maxValue);
                    Console.Write($" {array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");    
        }

        void PrintArrayDouble(double[,] array, int round=2)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {Math.Round(array[i, j], round)}\t");
                    //array[i, j] = Math.Round(array[i, j], round);
                }
                Console.WriteLine("\n");    
                    
            }
            Console.WriteLine();
        }

        int Input(string text)       
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task47() 
        {
            //Задача 47. Задайте двумерный массив размером m×n,
            //заполненный случайными вещественными числами,
            //округлёнными до одного знака.
            //m = 3, n = 4.
            //0,5 7 - 2 - 0,2
            //1 - 3,3 8 - 9,9
            //8 7,8 - 7,1 9

            int m = 3;
            int n = 4;
            int round = 1;
            double[,] numbers =new double[m, n]; 

            FillArrayDouble(numbers,1,10);
            PrintArrayDouble(numbers, round);
        }
        //Task47();

        void Task50() 
        {
            //Задача 50.Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что такого элемента нет.
            //Например, задан массив A:

            //1 4 7 2
            //5 9 2 3
            //8 4 2 4

            // A(1, 3)-> 3
            int m = Input("Введи количество строк = ");
            int n = Input("Введи количество столбцов = ");
            int x = Input("Введи номер строки = ");
            int y = Input("Введи номер столбца = ");

            double[,] matrix=new double[m,n];
            FillArrayDouble(matrix,1,5);

            if (x < matrix.GetLength(0)) 
            {
                if (y < matrix.GetLength(1)) 
                {
                    Console.WriteLine($"элемент [{x},{y}] = {matrix[x, y]} ");
                }
                else 
                {
                    Console.WriteLine("Такого элемента не существует");
                }
            }
            else
            {
                Console.WriteLine("Такого элемента не существует");
            }
        }
        //Task50();

        void FillArray(int[,] matrix, int minValue = 0, int maxValue = 10)
        {

            maxValue++;
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //Console.Write($"{i} ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Console.Write($"matrix[{i}{j}] ");
                    matrix[i, j] = random.Next(0, 10);

                }
                //Console.WriteLine($"output { i} end");
            }
        }
        void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //Console.Write($"{i} ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t ");

                }
                Console.WriteLine();
            }
        }

        void Task52() 
        {
            //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

            int m = 3;
            int n = 4;
            int[,] mas= new int[m, n];

            FillArray(mas);
            PrintArray(mas);
            
            Console.WriteLine();
            for (int i = 0; i < mas.GetLength(1); i++) 
            {
                double someSum = 0;
                for (int j = 0; j < mas.GetLength(0); j++) 
                {
                    someSum += mas[j, i];    
                }

                Console.Write($"{Math.Round(someSum / mas.GetLength(0),2)}\t");
            }


        }
        Task52();


    }
}