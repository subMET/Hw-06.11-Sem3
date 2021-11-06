string Task001(int x_1, int y_1)
{
    int x_sqare = x_1 * x_1;
    string result_1 = String.Empty;
    if (x_sqare == y_1)
    {
        result_1 = $"{y_1} является квадратом {x_1}.";
    }
    else { result_1 = $"{y_1} не является квадратом {x_1}."; }
    return result_1;
}

void Task002(int x_2, int y_2)
{
    if (x_2 == y_2) { Console.WriteLine($"Числа равны. {x_2} = {y_2}."); }
    if (x_2 > y_2) { Console.WriteLine($"{x_2} - большее, {y_2} - меньшее"); }
    if (y_2 > x_2) { Console.WriteLine($"{y_2} - большее, {x_2} - меньшее"); }
}

void Task003(int x_3)
{
    if (x_3 >= 1 & x_3 <= 7)
    {
        if (x_3 == 1) { Console.WriteLine("Понедельник."); }
        if (x_3 == 2) { Console.WriteLine("Вторник."); }
        if (x_3 == 3) { Console.WriteLine("Среда."); }
        if (x_3 == 4) { Console.WriteLine("Четверг."); }
        if (x_3 == 5) { Console.WriteLine("Пятница."); }
        if (x_3 == 6) { Console.WriteLine("Суббота."); }
        if (x_3 == 7) { Console.WriteLine("Воскресенье."); }
    }
    else { Console.WriteLine("Такого номера дня недели не существует."); }
}

void Task004(int x_4, int y_4, int z_4)
{
    Console.WriteLine($"Даны числа {x_4},{y_4},{z_4}.");
    int max = x_4;
    if (y_4 > max) { max = y_4; }
    if (z_4 > max) { max = z_4; }
    Console.WriteLine($"Максимальное число = {max}");
}

void Task005(int x_5)
{
    int y_5 = (-x_5 + 3) * (x_5 * 2 - 1) + 15;
    Console.WriteLine($"f({x_5}) = {y_5}");
}

void Task006(int x_6)
{
    if (x_6 % 2 == 0) { Console.WriteLine($"{x_6} - чётное число."); }
    else { Console.WriteLine($"{x_6} - нечётное число."); }
}

void Task007(int N_7)
{
    for (int j_7 = -N_7; j_7 <= N_7;)
    {
        Console.Write($"{j_7} ");
        j_7++;
    }
    Console.WriteLine();
}

void Task008(int N_8)
{
    for (int j_8 = 2; j_8 <= N_8;)
    {
        Console.Write(j_8 + " ");
        j_8 = j_8 + 2;
    }
    Console.WriteLine();
}

void Task009_010(int N_9)
{
    Console.WriteLine($"Дано число {N_9}");
    string N_9_2 = Convert.ToString(N_9);
    Console.Write(N_9_2[0]);
    Console.WriteLine(" - первая цифра.");
    Console.Write(N_9_2[1]);
    Console.WriteLine(" - вторая цифра.");
    Console.Write(N_9_2[2]);
    Console.WriteLine(" - третья цифра.");
}

string result_1_2 = Task001(2, 1);
Console.WriteLine(result_1_2);
Console.WriteLine();

Task002(8, 9);
Console.WriteLine();

Task003(1);
Console.WriteLine();

Task004(1, 7, 3);
Console.WriteLine();

Task005(0);
Task005(1);
Task005(2);
Task005(3);
Task005(4);
Task005(5);
Console.WriteLine();

Task006(6);
Console.WriteLine();

Task007(7);
Console.WriteLine();

Task008(10);
Console.WriteLine();

Task009_010(183);
