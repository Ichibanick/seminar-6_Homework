// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// System.Console.WriteLine("Введите количество чисел");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = 0;
// int num3 = 0;
// for (int i = 0; i < num1; i++)
// {
//     System.Console.WriteLine("Введите число");
//     num3 = Convert.ToInt32(Console.ReadLine());
//     if (num3 > 0)
//     {
//         num2++;
//     }
// }
// System.Console.WriteLine("количество чисел больше нуля " + num2);


// string? num1 = "";
// int num2 = 0;
// int num3 = 0;
// while ( num1 != "да")
// {
//     System.Console.WriteLine("Все числа введены?");
//     num1 = Console.ReadLine();
//     if (num1 == "нет")
//     {
//     System.Console.WriteLine("введите число");
//     num3 = Convert.ToInt32(Console.ReadLine());
//     }
//     else if (num1== "да")
//     {
//         num3 = 0;
//     }
//     else
//     {
//         System.Console.WriteLine("Введите да или нет");
//     }
//     if (num3 > 0)
//     {
//         num2++;
//     }
// }
// System.Console.WriteLine("количество чисел больше нуля " + num2);





// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// double X = 0;
// double Y = 0;
// void tochka ()
// {
//     System.Console.WriteLine("Задайте значение b1");
//     double b1 = Convert.ToDouble(System.Console.ReadLine());
//     System.Console.WriteLine("Задайте значение k1");
//     double k1 = Convert.ToDouble(System.Console.ReadLine());
//     System.Console.WriteLine("Задайте значение b2");
//     double b2 = Convert.ToDouble(System.Console.ReadLine());
//     System.Console.WriteLine("Задайте значение k2");
//     double k2 = Convert.ToDouble(System.Console.ReadLine());
//     if (k1 != k2)
//     {
//      X = ((b2-b1)/(k1 - k2));
//      System.Console.WriteLine(X);
//      Y = k1*((b2-b1)/(k1 - k2)) + b1;
//      System.Console.WriteLine(Y);
//     }
//     else
//     {
//         System.Console.WriteLine("k1 не должно ровняться k2");
//         return;
//     }

// }
// tochka();
// System.Console.WriteLine($" координаты ({X}, {Y})");

// int Prompt (string? message)
// {
// System.Console.Write(message);
// string? readInput = System.Console.ReadLine();
// int result = int.Parse(readInput);
// return result;
// }
// int Power( int powerBase, int exponent)
// {
//     int power = 1; 
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }

// bool ValidateExponent (int exponent)
// {
//     if ( exponent < 0)
//     {
//         System.Console.WriteLine("Показатель не должен быть меньше нуля");
//     return false;
//     }
//     return true;
// }
// int powerBase = Prompt("Введите основание: ");
// int exponent = Prompt("Введите показатель: ");
// if ( ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }
