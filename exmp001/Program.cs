﻿Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ??"";
int userNumber = int.Parse(userInput);

int result = userNumber*userNumber;

Console.WriteLine($" {userNumber} -> {result} ");