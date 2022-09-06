public class Homework05
{
    public static void Main(string[] args)
    {
        /*Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, 
        которая покажет количество чётных чисел в массиве.
        [345, 897, 568, 234] -> 2*/
        PozOfNumbers();

        /*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        Найдите сумму элементов, стоящих на нечётных позициях.
        [3, 7, 23, 12] -> 19
        [-4, -6, 89, 6] -> 0 */
        EvenPosition();

        /*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
        Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
        Результат запишите в новом массиве.
        [1 2 3 4 5] -> 5 8 3
        [6 7 3 6] -> 36 21*/
        ProductIsNumb();

        /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
        элементов массива. [3 7 22 2 78] -> 76*/
        RealNumbers();
     
    }

    static void PozOfNumbers()
    /*Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, 
    которая покажет количество чётных чисел в массиве.*/
    {
        Console.WriteLine("Введите длину массива: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[number];
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 999);
        }
        Console.WriteLine($"Задан массив: {String.Join(", ", array)}");

        for(int j = 0; j < array.Length; j++)
        {
            if(array[j] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество чётных чисел в массиве равно {count}");
    }

    static void EvenPosition()
    /*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.*/
    {
        Console.WriteLine("Введите длину массива: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[number];
        int sumElements = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-10, 10);

            if (i % 2 != 0)
            sumElements = sumElements + array[i];
        }

        Console.WriteLine($"Задан массив: {String.Join(", ", array)}");
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sumElements}");
    }

    static void ProductIsNumb()
    /*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
    Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
    Результат запишите в новом массиве.*/

    {
        Console.WriteLine("Введите длину массива: ");
        int number = Convert.ToInt32(Console.ReadLine());
                               
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 20);
        }
        Console.WriteLine($"Задан массив: {String.Join(", ", array)}");

        int[] arrayB = new int[number/2+1];
        int[] arrayC = new int[number/2];
        
        if (number % 2 != 0)
        {
            
            for (int j = 0; j < array.Length/2; j++)
            {
                int result = array[j] * array[number-1];
                arrayB[j] = result;
                number = number - 1;            
            }
             arrayB[number/2+1] = array[array.Length/2];
             Console.WriteLine($"произведение пар чисел равно: {String.Join(", ", arrayB)}");
        }
        else
        {
            for (int j = 0; j < array.Length/2; j++)
            {
                int result = array[j] * array[number-1];
                arrayC[j] = result;
                number = number - 1;            
            }
            Console.WriteLine($"произведение пар чисел равно: {String.Join(", ", arrayC)}"); 
        }
    }

    static void RealNumbers()
    /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
    элементов массива. [3 7 22 2 78] -> 76*/

    {
       double[] array = new double[10];
       double min, max;
       max = double.MinValue;
       min = double.MaxValue;
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
        }
        Console.WriteLine($"Задан массив: {String.Join(", ", array)}");
        
        for (int i = 0; i < array.Length; i++)
        {
           if(array[i] < min)
           {
                min = array[i];
           }
           if (array[i] > max)
           {
                max = array[i];
           }
        }
       double result = max - min;
       Console.WriteLine($"Минимальный элемент: {min}, максимальный элемент: {max}, разница между элементом массива = {result}");

    }
    static double MinValue 
    {
        get 
        {
            return Double.MinValue;
        }
    }

    static double MaxValue 
    {
        get 
        {
            return Double.MaxValue;
        }
    }    
}




