using System;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
class Principal {
          static int num1;
          static int num2;
          static int result;
          static string type;
        static void Main() {
          
          Console.WriteLine("Welcome to calculate");
          count();
        }

        static void count() {
          Console.WriteLine("Whats is do you do ?");
          Console.WriteLine("|S| - Sum |M| - Subtraction |D| - Division |V| - Multipication");
          type = Console.ReadLine();
          if (type == "S" || type == "s") {
            sum();
          } else if (type == "M" || type == "m"){
            subtraction();
          } else if (type == "D" || type == "d" ){
            division();
          } else if (type == "V" || type =="v") {
            multiplication();
          } else {
            Console.WriteLine("I dont understand try again\n");
            count();
          }
        }

        static void sum() {
          string op;
          Console.WriteLine("Type now the first number for sum");
          num1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Type now the second number for sum");
          num2 = Convert.ToInt32(Console.ReadLine());

          result = num1 + num2;

          Console.WriteLine("The results of the numbers is: " + result );

          Console.WriteLine("\nWould you like another operation ?");
          Console.WriteLine("Y - Yes | N - No");
          op = Console.ReadLine();

          if (op == "Y" || op == "y"){
            count();
          } else if (op == "N" || op == "n"){
          Console.WriteLine("Thanks for use");
          } else {
            Console.WriteLine("Try again"); 
            another();
          }
        }

        static void subtraction() {
          string op;

          Console.WriteLine("Type now the first number for subtraction");
          num1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Type now the second number for subtraction");
          num2 = Convert.ToInt32(Console.ReadLine());

          result = num1 - num2;
          Console.WriteLine("The results of the numbers is: " + result);

          Console.WriteLine("\nWould you like another operation ?");
          Console.WriteLine("Y - Yes | N - No");
          op = Console.ReadLine();

          if (op == "Y" || op == "y"){
            count();
          } else if (op == "N" || op == "n"){
          Console.WriteLine("Thanks for use");
          } else {
            Console.WriteLine("Try again"); 
            another();
          }
        }

        static void division() {
          string op;

          Console.WriteLine("Type now the first number for division");
          num1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Type now the second number to division");
          num2 = Convert.ToInt32(Console.ReadLine());

          result = num1 / num2;
          Console.WriteLine("The result od the numbers is: " + result);

          Console.WriteLine("\nWould you like another operation ?");
          Console.WriteLine("Y - Yes | N - No");
          op = Console.ReadLine();

          if (op == "Y" || op == "y"){
            count();
          } else if (op == "N" || op == "n"){
          Console.WriteLine("Thanks for use");
          } else {
            Console.WriteLine("Tray again");
            another();
          }
        }

        static void multiplication () {
          string op;

          Console.WriteLine("Type now teh first number for multiplication");
          num1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Type now the second number for multiplication");
          num2 = Convert.ToInt32(Console.ReadLine());

          result = num1 * num2; 

          Console.WriteLine("The result of the numbers is: " + result);

          Console.WriteLine("\nWould you like another operation ?");
          Console.WriteLine("Y - Yes | N - No");
          op = Console.ReadLine();

          if (op == "Y" || op == "y"){
            count();
          } else if (op == "N" || op == "n"){
          Console.WriteLine("Thanks for use");
          } else {
            Console.WriteLine("Try agin");
            another();
          }
        }
        static void another () {
          string op;

          Console.WriteLine("\nWould you like another operation ?");
          Console.WriteLine("Y - Yes | N - No");
          op = Console.ReadLine();

          if (op ==  "Y" || op == "y") {
            count();
          } else if (op == "N" || op == "n") {
            Console.WriteLine("Thanks for use");
          } else {
            Console.WriteLine("I don't understand try again");
            another();
          }

        }
    }
