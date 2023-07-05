void Task1()
{

Console.WriteLine("введите число №1");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число №2");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{ 
    Console.WriteLine($"Максимальное число\t{numberA}");
}
else
{
    Console.WriteLine($"Максимальное число\t{numberB}");
} 
}


void Task2()
{
Console.WriteLine("введите число №1");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число №2");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число №3");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberC < numberA)
  
{ 
    Console.WriteLine($"Максимальное число\t{numberA}");
}
if (numberB > numberA && numberC < numberB)
{
    Console.WriteLine($"Максимальное число\t{numberB}");
}
 else 
{
    Console.WriteLine($"Максимальное число\t{numberC}");
} 
}

void Task3()
{
Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine("четное");
}
else
{
Console.WriteLine("не четное");
}
}

void Task4()
{
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
    
for (int counter = 1; counter <= number; counter++)
    if (counter % 2 == 0)
        Console.Write(counter + " ");

}

void Task5()
{
Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;
while (counter <= number)
{
   if (counter%2 == 0)
   {
    Console.Write(counter + " ");
    counter++;
   }
   
}
}

Task5();