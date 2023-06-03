// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Main();

void Main()
{
    int b1 = Prompt("Введите число b1: ");
    int k1 = Prompt("Введите число k1: ");
    int b2 = Prompt("Введите число b2: ");
    int k2 = Prompt("Введите число k2: ");
    if (CheckValideNums(k1, k2) == true)
    {
        FindPoint(b1, k1, b2, k2);
    }
}

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine()!);
    return value;
}

bool CheckValideNums(int kFirst, int kSecond)
{
    if (kFirst - kSecond == 0)
    {
        Main();
        return false;
    }
    return true;
}

void FindPoint(int bOne, int kOne, int bTwo, int kTwo)
{
    double bI = Convert.ToDouble(bOne);
    double kI = Convert.ToDouble(kOne);
    double bII = Convert.ToDouble(bTwo);
    double kII = Convert.ToDouble(kTwo);
    double x = (bII - bI) / (kI - kII);
    double y = kI * x + bI;
    Console.WriteLine($"Координаты точки пересечения прямых: ({x}, {y})");
}