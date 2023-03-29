// Task2. Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру из этого числа. 


// int MaxNumber(int num)
// {
//     int teens = num / 10;
//     int units = num % 10;

//     return Math.Max(teens, units);
// }


// int randNum = new Random().Next(10, 100);
// int maxNum = MaxNumber(randNum);

// System.Console.WriteLine($"Your random number is {randNum}\nYour max number is {maxNum}");

    




//Напишите программу, которая принимает на вход 
//число и проверяет кратно ли оно одновременно "a" и "b".


// void IsMultiple(int num, int a, int b)
// {
//     if (num % a == 0 && num % b == 0)
//     {
//         System.Console.WriteLine($"Your number {num} is multiple of {a} and {b}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Your numbers {num}, {a} and {b} don't match the task condition. Try again. For restart input <dotnet run>");
//     }
// }

// Console.Write("Input your number to find the result: ");
// int num = Convert.ToInt32(Console.ReadLine());


// Console.Write("Input your a-number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input your b-number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// IsMultiple(num, a, b);






// Task4. Напишите программу, которая принимает на вход два 
// числа и проверяет является ли одно из них квадратом другого.


// void IsSquare(int num1, int num2)
// {
//     if (num1 == num2 * num2)
//     {
//        System.Console.WriteLine($"The first number {num1} is the square of the second number {num2}");
//     }
//     else if (num2 == num1 * num1)
//     {
//        System.Console.WriteLine($"The second number {num1} is the square of the first number {num2}");
//     }
//     else if (num1 == num2)
//     {
//         System.Console.WriteLine("Your numbers are equal");
//     }  
//     else
//     {
//         System.Console.WriteLine($"Your numbers {num1} and {num2} are not each other's square");
//     }
// }


// Console.Write("Input your first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input your second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// IsSquare(num1, num2);


