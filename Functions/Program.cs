void Task27()
{
    
    Console.WriteLine("введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (number > 0)
    {
        int num = number%10;
        number = number/10;
        sum = sum + num;
    }
    Console.WriteLine("сумма всех цифр в числе: " + sum );

}   

void Task25()
{
    Console.WriteLine("введите число A");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int num = numberA;
    for (int i = 1; i < numberB; i++)
    {
        num = num*numberA;
    }
    Console.WriteLine("A в степени B равно: " + num);
}

void Task29()
{
    int size = 8;
    Random rnd = new Random();
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = rnd.Next(0, 100);
    }

    for (int i = 0; i < size; i++)
    {   
        Console.Write($"{numbers[i]} ");
    }

    Console.WriteLine();

    int temp;

    for (int i = 0; i < size - 1; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            if (numbers[i] > numbers[j])
            {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }

    Console.WriteLine("Вывод отсортированного массива: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} " );
    }
        Console.WriteLine();
}

Task27();
Task25();
Task29();