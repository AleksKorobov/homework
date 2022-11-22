// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
//String s = Console.ReadLine();
//Console.WriteLine(s[0])(s[2]);
//int sl2=number%10 ;
//sl1=sl1*10+number%10 ;
//Console.WriteLine(sl1) ;

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int x1=num/10;
int x2= x1 % 10;
Console.WriteLine(x2);


