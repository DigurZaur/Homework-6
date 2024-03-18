// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();
string reversedInput = new string(input.ToCharArray(), 0, input.Length);
reversedInput = reversedInput.Replace(" ", "");
if (string.Equals(reversedInput, new string(reversedInput.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Да, это палиндром.");
    }
else
    {
        Console.WriteLine("Нет, это не палиндром.");
    }