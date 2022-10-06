using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InheritanceCalculus
{
    internal class CalculusActions
    { 
        public string Actionchoice { get; set; }

        public CalculusActions(string actionchoice)
        {  
            Actionchoice = actionchoice;            
        }
        public static void WelcomeMenu()
        {
            Console.WriteLine("   - ¬ = Super Calculus = ¬ -");
            Console.WriteLine(" + - * / % Make choice % / * - +");
            Console.WriteLine("1. Add + ._. 2. Substract -._. 3. Multiplicate * ._. 4. Divide / ._. 5. Get percentage % ._. 6. Exit app.");
            Console.WriteLine();
            Choice();
            NewCalculus();
            Exit();
        }
        public static void Choice()
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice++)
            {
                case 1:
                    {
                        Console.WriteLine("Addition + ");
                        Console.WriteLine("Number 1: ");
                        decimal number1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Number 2: ");
                        decimal number2 = decimal.Parse(Console.ReadLine());
                        decimal addsum = number1 + number2;
                        Console.WriteLine($"Addition result: {number1} + {number2} = {addsum} .");
                        Console.WriteLine();
                        return;
                    }
                case 2:
                    {
                        Console.WriteLine("Substraction: ");
                        Console.WriteLine("Number 1: ");
                        decimal number1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Number 2: ");
                        decimal number2 = decimal.Parse(Console.ReadLine());
                        decimal subsum = number1 - number2;
                        Console.WriteLine($"Substraction result: {number1} - {number2} = {subsum} .");
                        //decimal subsum2 = number2 - number1;
                        //Console.WriteLine($"Substraction result 2: {subsum2} .");
                        Console.WriteLine();
                        return;
                    }
                case 3:
                    { 
                    Console.WriteLine("Multiplication: ");
                    Console.WriteLine("Number 1: ");
                    decimal number1 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Number 2: ");
                    decimal number2 = decimal.Parse(Console.ReadLine());
                    decimal mulsum = number1 * number2;
                    Console.WriteLine($"Multiplication result: {number1} * {number2} = {mulsum} .");
                    Console.WriteLine();
                    return;
                    }
                case 4:
                    {
                        Console.WriteLine("Division: ");
                        Console.WriteLine("Number 1: ");
                        decimal number1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Number 2: ");
                        decimal number2 = decimal.Parse(Console.ReadLine());
                        decimal divsum = number1 / number2;
                        Console.WriteLine($"Division result: {number1} / {number2} = {divsum} .");
                        Console.WriteLine();
                        return;
                    }
                case 5:
                    {
                        Console.WriteLine("Percentage: ");
                        Console.WriteLine("Number 1: ");
                        decimal number1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Number 2: ");
                        decimal number2 = decimal.Parse(Console.ReadLine());
                        decimal persum = (number1 / number2) * 100;
                        Console.WriteLine($"Number {number1} = {persum} % from number {number2} .");
                        Console.WriteLine();
                        return;
                    }
                case 6:
                    {
                        Exit();                       
                        return;
                    }
            }
        }
        public static void NewCalculus()
        {
            WelcomeMenu();
        }
        public static void Exit()
        {           
            Console.WriteLine("+-=*%/¬ Thanks ¬/%*=-+");
            Environment.Exit(0);
        }
       
    }   
}
