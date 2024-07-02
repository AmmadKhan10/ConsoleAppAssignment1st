using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1st
{
    internal class ArthematicOperation
    {
        //public void NumbersTable()
        //{
        //    Console.WriteLine("Enter the first number");
        //    var a = Convert.ToInt32( Console.ReadLine() );
        //    Console.WriteLine("Enter the last number");
        //    var b = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= b; i++)
        //    {

        //        Console.WriteLine($"{a} X {i} =" + a*i);
        //    }


        //Add py with the Name or string;
        //public void Addpy()
        //{
        //    string Name;
        //    string py;
        //    Console.WriteLine("Enter String");
        //    Name = Console.ReadLine();

        //    if (Name.StartsWith("PY") || Name.StartsWith("py"))
        //    {
        //        Console.WriteLine(Name);
        //    }
        //    else
        //    {
        //        Console.WriteLine("py" + Name);
        //    }
        //} 

        // Remove character from a string 
        //public void RemoveChar()
        //{
        //    Console.WriteLine("Enter String Here ");
        //    var str = Console.ReadLine();
        //    Console.WriteLine("Enter Index ");
        //    var index = Convert.ToInt32(Console.ReadLine());
        //    if (index < 0 || index > str.Length)
        //    {
        //        Console.WriteLine("Invalid Index");
        //    }
        //    else
        //    {
        //        var newstr = str.Remove(index, 1);
        //        Console.WriteLine("The new string is " + newstr);
        //    }
        //}


        //Exchange 1st and last character with each other
        //public void ExchangeChar()
        //{
        //    Console.WriteLine("Enter String here");
        //    var str = Console.ReadLine();
        //    var firstchar = str[0];
        //    var lastchar = str[str.Length-1];
        //    var newstr = lastchar + str.Substring(1, str.Length - 2) + firstchar;
        //    Console.WriteLine(newstr);
        //}


        //Add first char at the start and at the end of the string
        //public void CharExchange()
        //{
        //    Console.WriteLine("Enter string here to");
        //    var str = Console.ReadLine();
        //    var firstchar = str[0];
        //    var newstr = firstchar + str + firstchar;
        //    Console.WriteLine("The new string is " + newstr);
        //}


        //Check the multiple of 3 or 7
        //public void CheckMultiple()
        //{
        //    Console.WriteLine("Enter a number to check multiple");
        //    var num = Convert.ToInt32( Console.ReadLine());
        //    if (num < 0)
        //    {
        //        Console.WriteLine("Enter a possitive number");
        //    }
        //    else if (num %3==0 || num % 7 == 0)
        //    {
        //        Console.WriteLine($"The {num} is divisible of 3 or 7");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The {num} is not divisible of 3 or 7");
        //    }
        //}


        //Add the last three char at the start and at the end of the string
        //public void AddThreeChar()
        //{
        //    Console.WriteLine("Enter a string here");
        //    var str = Console.ReadLine();
        //    var lastchar = str.Substring(str.Length-3);
        //    var newstr = lastchar + str + lastchar;
        //    Console.WriteLine("The new string is " + newstr);
        //}


        //Find the greatest number between three number
        //public void GreatestNumber()
        //{
        //    Console.WriteLine("Enter first Number");
        //    var num1 =Convert.ToInt32( Console.ReadLine());
        //    Console.WriteLine("Enter second Number");
        //    var num2 =Convert.ToInt32( Console.ReadLine());
        //    Console.WriteLine("Enter third Number");
        //    var num3 = Convert.ToInt32(Console.ReadLine());
        //    if (num1 > num2 && num1 > num3)
        //    {
        //        Console.WriteLine($"The greatest number is " + num1);
        //    }
        //    else if (num2 > num1 && num2 > num3)
        //    {
        //        Console.WriteLine($"The greatest number is " +  num2);
        //    }
        //    else if (num3 > num1 && num3 > num2)
        //    {
        //        Console.WriteLine($"The greatest number is " + num3);
        //    }
        //    else if(num1 == num2 && num1== num3)
        //    {
        //        Console.WriteLine("Enter Differnt number");
        //    }

        //}


        //Check the marks of the student if marks is greater than 80 and print A+ Grade
        //public void CheckMarks()
        //{
        //    Console.WriteLine("Enter Marks to check grade");
        //    var marks = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Exam Type Is Final?");
        //    var is_final = Convert.ToBoolean(Console.ReadLine());

        //    if (marks >= 80 && marks <= 90)
        //    {
        //     if (is_final) { 
        //        Console.WriteLine($"marsk with {marks} is A+ Grade");
        //        }
        //     else
        //        {
        //         Console.WriteLine($"marsk with {marks} is A+ Grade");
        //        }
        //    }
        //    else if (marks >= 90 && marks <= 100 && is_final)
        //    {
        //        Console.WriteLine($"marsk with {marks} is A+ Grade and is Final {is_final}");

        //    }
        //    else
        //    {
        //        Console.WriteLine("No grade");
        //    }
        //}


        //In this Question we check if number is in between 50 and 80 print 65 otherwise print 80

        //public void CheckSum()
        //{
        //    Console.WriteLine("Enter first num");
        //    var num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Second num");
        //    var num2 = Convert.ToInt32(Console.ReadLine());
        //    var result = num1 + num2;
        //    if (result >= 50 && result <= 80)
        //    {
        //        Console.WriteLine("65");
        //    }
        //    else
        //    {
        //        Console.WriteLine("80");
        //    }
        //}


        //This question is about to check whether number is even or odd
        //public void CheckEvenAndOddNumber()
        //{
        //    //var i;
        //    for (int i = 0; i <= 15; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine($"{i} is even");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{i} is odd");
        //        }
        //    }
        //}

        // In this question find the multiple of 3 and 5 and print fizz and buzz
        //public void CheckNumberMultiple()
        //{

        //    for (int i = 1; i <= 100; i++)
        //    {
        //         if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine($"{i} is FizzBuzz");
        //        }
        //       else if (i % 3 == 0)
        //        {
        //            Console.WriteLine($"{i} is Fizz");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine($"{i} is Buzz");
        //        }

        //    }
        //}

        //public void Multipleof3And5()
        //{
        //    int Sum = 0;
        //    for (int i = 1; i <= 1000; i++)
        //    {
        //        if (i % 3 == 0 || i % 5 == 0)
        //        {
        //            Console.WriteLine(i);
        //            Sum = Sum + i;
        //        }
        //    }
        //    Console.WriteLine("sum is " + Sum);
        //}

        // Sum of array numbers without loop 

        //public void SumArray()
        //{
        //    int[] numberArray = { 1, 13, 22, 123, 49 };
        //    int sum = numberArray.Sum();
        //    Console.WriteLine("sum of Array is " + sum);
        //    }

        //}

        // // Sum of array numbers with loop 
        //public void SumArray()
        //{
        //    int sum = 0;
        //    int[] numberArray = { 1, 13, 22, 123, 49 };
        //    foreach (int num in numberArray)
        //    {
        //        sum = sum + num;
               
        //    }

        //     Console.WriteLine("sum of Array is " + sum);

        //}

           
        //Check whether a given number is positive or negative number

        //public void CheckNumberIsPositiveNegative()
        //{
        //    Console.WriteLine("Enter a number to check whether positive or negative");
        //    int num =Convert.ToInt32( Console.ReadLine());
            
        //    if(num > 0)
        //    {
        //        Console.WriteLine($"{num} is positive Number");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is negative Number");
        //    }
        //}

        public void TicketPrice()
        {
            Console.WriteLine("Enter your age to check Price of your Ticket");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 12)
            {
                Console.WriteLine("Your Ticket price is 5");
            }
            else if (Age > 12 && Age <18)
            {
                Console.WriteLine("Your Ticket price is 10");
            }
            else if (Age > 18 && Age < 60)
            {
                Console.WriteLine("Your Ticket price is 20");
            }
            else if (Age > 60)
            {
                Console.WriteLine("Your Ticket price is 15");
            }
        }
       

    }
}
