var processor = new ArrayProcessor();

// Пример массива
int[] array = { 1, 2, 3, 4, 5 };

// Вывод исходного массива
Console.WriteLine("Исходный массив: " + string.Join(", ", array));

// Реверс массива
int[] reversedArray = processor.ReverseArray(array);
Console.WriteLine("Реверсированный массив: " + string.Join(", ", reversedArray));

// Подсчёт чётных чисел
int evenCount = processor.CountEvenNumbers(array);
Console.WriteLine($"Количество чётных чисел: {evenCount}");

// Умножение всех элементов на 2
int multiplier = 2;
int[] multipliedArray = processor.MultiplyArrayElements(array, multiplier);
Console.WriteLine($"Массив после умножения на {multiplier}: " + string.Join(", ", multipliedArray));

// Пример работы с граничными случаями
Console.WriteLine("\nГраничные случаи:");

// Пустой массив
int[] emptyArray = { };
Console.WriteLine("Пустой массив:");
Console.WriteLine("Реверсированный: " + string.Join(", ", processor.ReverseArray(emptyArray)));
Console.WriteLine("Количество чётных чисел: " + processor.CountEvenNumbers(emptyArray));

// Массив из одного элемента
int[] singleElementArray = { 42 };
Console.WriteLine("\nМассив из одного элемента:");
Console.WriteLine("Исходный: " + string.Join(", ", singleElementArray));
Console.WriteLine("Реверсированный: " + string.Join(", ", processor.ReverseArray(singleElementArray)));
Console.WriteLine("Количество чётных чисел: " + processor.CountEvenNumbers(singleElementArray));
Console.WriteLine("После умножения на 3: " + string.Join(", ", processor.MultiplyArrayElements(singleElementArray, 3)));

// Завершение работы
Console.WriteLine("\nНажмите любую клавишу для завершения...");
Console.ReadKey();