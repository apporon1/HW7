using System;

public class ArrayProcessor
{
    // Метод для реверса массива
    public int[] ReverseArray(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Массив не может быть null");

        int[] reversed = new int[array.Length];
        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {
            reversed[i] = array[j];
        }

        return reversed;
    }

    // Метод для подсчёта количества чётных чисел в массиве
    public int CountEvenNumbers(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Массив не может быть null");

        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
                count++;
        }

        return count;
    }

    // Метод для умножения всех элементов массива на заданное число
    public int[] MultiplyArrayElements(int[] array, int multiplier)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Массив не может быть null");

        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i] * multiplier;
        }

        return result;
    }
}
