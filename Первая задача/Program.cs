/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

System.Console.WriteLine("Введите количестов чисел М: ");

int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int Summ(int n)

{
int sum = 0;
for (int i = 0; i < n; i++)
{
System.Console.WriteLine($"Введите {i + 1} число: ");
arr[i] = Convert.ToInt32(Console.ReadLine());
if (arr[i] > 0) sum ++;
}
return sum;
}

System.Console.WriteLine($"Количество чисел которых больше нуля = {Summ(n)}");