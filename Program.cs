int len;

bool isValidLen = false;
while (true)
{
    Console.Write("Введите длинну массива: ");
    isValidLen = int.TryParse(Console.ReadLine(), out len);
    if (isValidLen == false)
    {
        Console.WriteLine("Некорректное значение\n");
    }
    else if (len <= 0)
    {
        Console.WriteLine("Длинна массива должна быть больше 0\n");
        isValidLen = false;
    }
    else
        break;
}
Console.WriteLine();

int[] num = new int[len];
for (int i = 0; i < len; i++)
{
    bool isValidNumber = false;
    while (true)
    {
        Console.Write($"num[{i}] = ");
        isValidNumber = int.TryParse(Console.ReadLine(), out num[i]);
        if (isValidNumber == false)
        {
            Console.WriteLine("Некорректное значение\n");
        }
        else
            break;
    }
}

int count_of_zeros = 0;
for (int i = 0; i < len; i++)
{
    if (num[i] == 0)
    {
        count_of_zeros++;
    }
}
if (count_of_zeros == len)
{
    Console.WriteLine();
    for (int i = 0; i < len; i++)
    {
        Console.Write("0 ");
    }
    Console.WriteLine();
    return;
}

for (int i = 0; i < len; i++)
{
    if (num[i] == 0)
    {
        for (int index = i; index < len - 1; index++)
        {
            num[index] = num[index + 1];
        }
        num[len - 1] = 0;
    }
    if (num[0] == 0)
    {
        i--;
    }
}

Console.WriteLine();

for (int i = 0; i < len; i++)
{
    Console.Write($"{num[i]} ");
}

Console.WriteLine();