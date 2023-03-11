Console.WriteLine ("Программа для вычесления рандомных чисел А + В или А - В");

int numberA = new Random().Next(1, 10); // Диапозон от 1 до 10
int numberB = new Random().Next(1, 10); // Диапозон от 1 до 10

Console.Write("Первое рандомное число - "); Console.WriteLine(numberA); 
Console.Write("Второе рандомное число - "); Console.WriteLine(numberB);

int result = numberA + numberB;

Console.Write("ИТОГО получаем число : "); Console.WriteLine(result);