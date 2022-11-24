// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine(" Введите пятизначное число");
String s = Console.ReadLine();
if(s[0].ToString()== s[4].ToString() && s[1].ToString() == s[3].ToString()) 
    {
    Console.WriteLine("да");
    }
else
    {
    Console.WriteLine("нет");
    } 