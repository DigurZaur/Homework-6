// Задача 2: Задайте строку, содержащую латинские буквы в 
// обоих регистрах. Сформируйте строку, в которой 
// все заглавные буквы заменены на строчные.
System.Console.Write("Введите строку:");
string StR = Console.ReadLine();
string str = StR.ToLower();
System.Console.WriteLine(str);