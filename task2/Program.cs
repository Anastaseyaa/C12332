﻿using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже

//     firstNumber = int.Parse(Console.ReadLine());
//     secondNumber = int.Parse(Console.ReadLine()); 
    
    if (firstNumber < secondNumber)
    {
        Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");   
    }
    else if (firstNumber == secondNumber)
    {
        Console.WriteLine($"Введенные числа равны `{secondNumber}`");   
    }
    else
    {
        Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");   
    }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 15;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }


