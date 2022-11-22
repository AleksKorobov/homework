//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int x = 0;
//int y = num % 10;
int z = 0;
int y = 0;
if(num<100)
    {
    Console.WriteLine("Третьей цифры нет");
    }
if(num>10000)
    { 
        z = num % 1000;
        y = z/100;
        Console.WriteLine(y);
    }
if((num>1000)&&(num<10000))
    { 
        z = num % 100;
        y = z/10;
        Console.WriteLine(y);  
    }     
if((num>100)&&(num<1000))
    { 
        y = num % 10;
        Console.WriteLine(y);
    }    
    