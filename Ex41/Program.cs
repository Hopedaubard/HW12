// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Main();

void Main()
{
    int countNum = Prompt("Введите запланированное Вами количество обрабатываемых программой чисел: ");
    int[] array = GetArrayManual(countNum);
    CheckMoreZeroNumInArray(array);
}

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine()!);
    return value;
}

int[] GetArrayManual(int size)
{
    int[] userArray = new int[size];
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
}

void CheckMoreZeroNumInArray(int[] checkedArray)
{
    int count = 0;
    for (int j = 0; j < checkedArray.Length; j++)
    {
        if (checkedArray[j] < 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество введённых Вами отрицательных чисел (меньше 0) равняется {count} ");
}