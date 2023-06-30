// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int num2 = 1;

// System.Console.WriteLine(ConclusionNum(num1, num2)); // метод вызываем внутри КОМАНДЫ


// string ConclusionNum(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         return num1.ToString(); // условие выхода из рекусии
//     }
//     return (num1 + " " + ConclusionNum(num1 - 1, num2));
// }






// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число = ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число = ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write(PrintNum(number1, number2) + 1);// вызов метода внутри

// string PrintNum(int num1, int num2) // база метода и рекуссии будет как и в первой задаси
// {
// if (num1>num2)// но здесь проверку делаем на то что перое число больше втрого
// {
// return "Нет решения";// тут без консоль врайт лайн пишем нет решения аргумент
// }
// if (num1==num2)
// {
// return num1.ToString();// тут остановка рекурсии
// }

// return (num1+ PrintNum(num1+1, num2));
// } 
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0 && m>0) return Ack(m - 1, 1);
//     else return Ack(m - 1, Ack(m, n - 1));
// }




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число = ");
// int num1m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число = ");
// int num2n = Convert.ToInt32(Console.ReadLine());

// Console.Write(Akkerman(num1m, num2n));

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     } 
//     if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//         if (n < 0 || m < 0) 
//     {
//         Console.Write(" нет решения ");
//         return 0;
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }


