using System;
using System.Collections.Generic;
using System.Linq;


namespace Logical_Program
{
    public class Logics
    {
        //Find the even and odd value from the list
        public void FindEvenOddList()
        {
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
           
            foreach(int num in number)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine("Even number is: " + num);
                }
                else
                {               
                    Console.WriteLine("Odd number is: " + num);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        // It's a number that equals the sum of its digits, each raised to a power. 
        // Ex 153 =>    1+125+9=153    
        public void CheckArmstrongNumber()
        {
            Console.WriteLine("Enter a number to find it is Armstrong: ");
            int Number = int.Parse(Console.ReadLine()); //153

            int Original = Number;
            int Reminder, Sum = 0;
            while (Number > 0)
            {
                Reminder = Number % 10;     //3, 5, 1
                Sum = Sum + (Reminder * Reminder * Reminder);   //27, 125, 1
                Number = Number / 10;
            }

            if (Original == Sum)
            {
                Console.WriteLine($"{Original}: is an armstrong number");
            }
            else
            {
                Console.WriteLine($"{Original}: is not an armstrong number");
            }
        }

        public void SumofAllNumbers()
        {
            Console.WriteLine("Please enter the number");
            int Number = int.Parse(Console.ReadLine());     //1234
            int intNumber = Number;
            int Sum = 0; int temp;
            try
            {
                do
                {
                    if (Sum != 0)
                    {
                        Number = Sum;
                        Sum = 0;
                    }
                    while (Number > 0)
                    {
                        temp = Number % 10;
                        Sum = Sum + temp;
                        Number = Number / 10;
                    }
                }
                while (Sum > 9);

                Console.WriteLine($"Sum of the given {intNumber} is: {Sum}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SwappingTwoNum()
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine($"Before SWapping number1 = {number1}, number2 = {number2}");
            temp = number1;     //temp=10
            number1 = number2;  //number1 =20
            number2 = temp;     //number2 = 10
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
            Console.ReadKey();
        }

        //Write the program which will print the number to string like 3456 => Three four Five Six
        public void NumberToString()
        {
            Console.WriteLine("Please enter a number to find Armstrong");       //1234
            int Number = int.Parse(Console.ReadLine());

            int Remainder = 0;
            int Reverse = 0;
            while (Number > 0)
            {
                Remainder = Number % 10;
                Reverse = Reverse * 10 + Remainder;
                Number = Number / 10;
            }
            while (Reverse > 0)
            {
                Remainder = Reverse % 10;
                switch (Remainder)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    case 0:
                        Console.Write("Zero ");
                        break;
                }
                Reverse = Reverse / 10;
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //Find the largest number from the Array 
        public void LargetNumberFromArray()
        {
            Console.WriteLine("Enter the array size: ");
            int UB = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] arr = new int[UB];
            for (int i = 0; i < UB; i++)
            {
                Console.WriteLine($"Enter the element of array: {i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int LargeNumebr = arr[0];

            for (int j = 0; j < UB; j++)
            {
                if (arr[j] > LargeNumebr)
                {
                    LargeNumebr = arr[j];
                }
            }
            Console.WriteLine("Greatest Number in the array is: " + LargeNumebr);
            Console.ReadLine();
        }

        //Write the program for Leap year
        public void LeafYear()
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is the leaf year");
            }
            else
            {
                Console.WriteLine($"{year} is not leaf year");
            }
        }

        //Write the program for convert Number to Bindary
        public void NumberToBinary()
        {
            Console.WriteLine("Enter the number want to convert into binary");
            int Number = int.Parse(Console.ReadLine());

            int[] arr = new int[16];
            int i;
            for (i = 0; Number > 0; i ++)
            {
                arr[i] = Number % 2;            // 1, 0, 0, 0, 0, 0, 1
                Number  = Number / 2;           // 32, 16, 8, 4, 2, 1, 0
            }
            Console.WriteLine("Binary value of the given number is: ");
            for(i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }

        //Write the program for Fibanocci Serise 
        //Sum of the previous two digit 
        //Ex: 0, 1, 1, 2, 3, 5, 8, 13, 21.....

        public void FibanocciSerise()
        {
            Console.WriteLine("Enter the number of elements for fibanocci serise: ");
            int Number = int.Parse (Console.ReadLine());

            int Num1 = 0, Num2 = 1, Num3;
            Console.Write(Num1 + " " + Num2 + " ");
            for (int i = 2; i < Number; i++)
            {
                Num3 = Num1 + Num2;
                Console.Write(Num3 + " ");
                Num1 = Num2;
                Num2 = Num3;
                Num3 = Num3 + Num2;
            }
            Console.ReadLine();
        }

        //Write the program to reverse the number.
        public void ReverseNumber()
        {
            Console.WriteLine("Enter the number: ");
            int Number = int.Parse(Console.ReadLine());
            //459 => 954

            int Reminder, Reverse = 0;
            while (Number > 0)
            {
                Reminder = Number % 2;
                Reverse = Reverse * 10 + Reminder;
                Number = Number / 10;
            }
            Console.WriteLine("Reversed Number is: " + Reverse);
            Console.ReadLine();
        }
        
        //Write the program for PalindromeNumber
        public void PalindromeNumber()
        {
            Console.Write("Enter the number: ");
            int Number = int.Parse(Console.ReadLine());
            int OldNumebr = Number;
            int Reminder, Reverse = 0;

            while (Number != 0)
            {
                Reminder = Number % 10;         
                Reverse = Reverse * 10 + Reminder;
                Number = Number / 10;
            }
            if(OldNumebr == Reverse)
            {
                Console.WriteLine("The given number is PalindromeNumber: " + OldNumebr);
            }
            else
            {
                Console.WriteLine("The given number is PalindromeNumber: " + OldNumebr);
            }
            Console.ReadLine();
        }

        //Find out the factorial of the Number     take uint to avaid the negative number
        public void factorial()
        {
            Console.Write("Enter a number to find it's factorial: ");
            uint Numner = uint.Parse(Console.ReadLine());

            uint fact = 1;
            for(uint i = 1; i <= Numner; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of the Number is: " + fact);
            Console.ReadLine();
        }

        //Print 1 to 100 without loop
        public void Print1To100()
        {
            Console.Write("Enter the number: ");
            int Num = int.Parse(Console.ReadLine());

            List<int> List = Enumerable.Range(1, Num).ToList();
            string str = string.Join(", ", List.Select(x=>x.ToString()));
            Console.WriteLine(str);
            Console.ReadLine();
        }

        //Write the program whether the Entered Number is Even or Odd
        public void EvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());

            if(Num % 2 == 0)
            {
                Console.WriteLine("Enter Number is Even Number: " + Num);
            }
            else
            {
                Console.WriteLine("Enter Number is Odd Number: " + Num);
            }
            Console.ReadLine();
        }

        //Write the program to Print Odd Numbers in a Given Range
        public void OddNumberRange()
        {
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());

            IEnumerable<int> oddNums = Enumerable.Range(1, Num).Where(x => x % 2 != 0);
            foreach (int n in oddNums)
            {
                Console.Write(n + ",");
            }
            Console.ReadLine();
        }

        //Bubble short
        public void Bublesort()
        {
            Console.Write("Enter size of arry number: ");

        }

        //Find the GCD of two number

        public void FindGCD()
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write(" \n THe Greatest common division of: ");     
            Console.WriteLine("{0} and {1} is {2}", num1, num2, GCD(num1, num2));
            Console.ReadLine();         
        }

        public int GCD(int num1, int num2)
        {
            int Remainder;
            while (num2 != 0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }
            return num1;
        }

    }
}
