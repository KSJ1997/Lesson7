// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите сколько чисел будет записано: ");
int Numbers = Convert.ToInt32(Console.ReadLine());

int[] ArrayCreate(int num)
    {
        int[] array = new int[num];
        for (int i = 0; i < array.Length; i++)
            {   
                Console.Write($"Введите {i+1} число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
        return array;
    }

int NumberOfPositiveNumbers (int [] array)
    {
        int SumPositive = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array [i] > 0) SumPositive++;
       
            }
        return SumPositive;
    }

int[] NewArray = ArrayCreate(Numbers);
Console.WriteLine($"Кол-во чисел больше 0 равно -> {NumberOfPositiveNumbers(NewArray)}");