// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int countPlus = 0;
int M;
Console.WriteLine("Укажите сколько ввести чисел: ");
M = Convert.ToInt32(Console.ReadLine());
 int[] mas = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < M; i++)
    {
        if (mas[i] > 0)
        {
            countPlus++;
        }
    }
    
    Console.WriteLine();
    Console.WriteLine("Количество чисел больше нуля = " + countPlus);