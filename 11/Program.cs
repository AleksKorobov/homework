Console.WriteLine("Введите число дня недели от 1 до 7: ");

int num = int.Parse(Console.ReadLine());

if((num == 1)||(num == 2)||(num == 3)||(num == 4)||(num == 5))
        {
            Console.WriteLine("Нет");
        }
if((num == 6)||(num == 7))
        {
            Console.WriteLine("Да");
        }
