void Task10()
{
        Random rnd = new Random();
        int number = rnd.Next(100,1000);
        Console.WriteLine($"Выпало случайное число: {number}");

    
        int f_digit = number/10;
        int s_digit = f_digit%10;
        

        Console.WriteLine(s_digit);
}

void Task15()
{
       /* Random rnd = new Random();
        int number = rnd.Next(1,8);
        Console.WriteLine($"Выпало случайное число: {number}");

    if (number < 6)
        {
            Console.WriteLine($"{number} - не является выходным");
        }

    else 
        {
            Console.WriteLine($"{number} - является выходным");
        }*/


        

}
    void Sample(int number)
    {
        if (number > 1 && number <= 5)
        {
            System.Console.WriteLine("День не является выходным");
        } 
        else if(number>5 && number <=7)
        {
            System.Console.WriteLine("День является выходным");
        }
        else
        {
            System.Console.WriteLine("Такого дня недели нет");
        }
}


void Task13()
{
        Random rnd = new Random();
        int number = rnd.Next();
        Console.WriteLine($"Выпало случайное число: {number}");


        if (number<100)
        {
            Console.WriteLine("третьей цифры нет");
        }
        else
        {
            while (number >= 1000)
            {
                 number = number/10;
                 
            }
            Console.WriteLine(number%10);
            
        }
        
            
        

}


