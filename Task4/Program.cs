// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова расположены
// в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Введите строку из слов, разделенных пробелами:");
string input = Console.ReadLine();
string[] words = input.Split(' ');
Array.Reverse(words);
string reversedString = string.Join(" ", words);
Console.WriteLine("Результат: " + reversedString);