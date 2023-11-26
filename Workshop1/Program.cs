﻿// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int size = 10;
int min = 1;
int max = 100;

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)
{
    int count = 1;
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (arr[i] >= 20 && arr[i] <= 90) count++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел из диапазона [20, 90] равно {count}");
    System.Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));