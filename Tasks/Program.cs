void Task21()

{
    Console.WriteLine("Write X: ");
    int x1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write Y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write Z: ");
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write X2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write Y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write Z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    int A = x2 - x1;
    int B = y2 - y1;
    int C = z2 - z1;

    Console.WriteLine($"Distance {Math.Sqrt(A * A + B * B + C * C)}");
}

Task21();

void Task23()
{
    Console.WriteLine("write number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"{counter}^3 = {Math.Pow(counter, 3)}");
        counter++;
    }

}
Task23();

void Task19() 

{
    Console.WriteLine("Ведите пятизначное число");
    int number = int.Parse(Console.ReadLine());
    int pal = 0, num = number;
    while (number > 0)
    {
        pal = pal * 10 + number % 10;
        number /= 10;
    }
        if (num == pal)
    {
    Console.WriteLine("палиндром");
    }
    else
    {
    Console.WriteLine("не палиндром");
    }
}

Task19();


