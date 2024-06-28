using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logical_Program
{
    public class StringManupulation
    {
        // Write the program to find the string length
        public void StringLength()
        {
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();

            int Length = 0;
            foreach (char ch in input)
            {
                Length++;
            } 
            
            Console.WriteLine("The length of the string is: " +  Length);
            Console.ReadLine();
        }

        //Write the program CharToArray
        public void charToArray()
        {
            Console.Write("Enter the string to convert array: ");
            string input = Console.ReadLine().Trim();

            int Length = 0;
            foreach (char ch in input)
            {
                Length++;
            }

            char[] arr = new char[Length];
            int index = 0;
            foreach (char ch in input)
            {
                arr[index] = ch;
                index++;
            }          
            
            Console.WriteLine(arr);
            Console.ReadLine();
        }

        //Write the program to find the duplicate from the string
        public void DuplicateChar()
        {
            Console.Write("Enter your string to find the duplicate charactor: ");
            string input = Console.ReadLine();

            int Length = 0; 
            foreach (char ch in input)
            {
                Length +=1;
            }

            char[] arr = new char[Length];
            int index =0;
            foreach (char ch in input)
            {
                arr[index] = ch;
                index++;
            }

            int count1 = 0, count2 = 0;
            foreach (char ch1 in arr)
            {
                count1 += 1;
                foreach (char ch2 in arr)
                {
                    count2 += 1;
                    if (count1 != count2)
                    {
                        if (ch1 == ch2 && ch1 != 32)
                        {
                            Console.WriteLine(ch1);
                            arr[count1 - 1] = ' ';
                            arr[count2 - 1] = ' ';
                            break;
                        }
                    }                   
                }
                count2 = 0;
            }
            Console.ReadLine ();
        }

        // Write the program to which unique in string
        public void UniqueChars()
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine ();

            bool Exist = false;

            int count1 = 0, count2 = 0;
            foreach(char ch1 in input)
            {
                count1 += 1;
                foreach (char ch2 in input)
                {
                    count2 += 1;

                    if(count1 != count2)
                    {
                        if (ch1 != ch2 && ch1 != 32)
                        {
                            Exist = false;
                        }
                        else
                        {
                            Exist = true;
                            break;
                        }
                    }
                }
                if(Exist == false)
                {
                    Console.Write(ch1);
                }
                else
                {
                    count2 = 0;
                    Exist = false;
                }           
            }
            Console.ReadLine();
        }

        //write the program to Reverse String
        public void StringReverse()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine ();

            string reverse = "";

            foreach(char ch in input)
            {
                reverse = ch + reverse;
            }
            Console.WriteLine($"Reverse of given string {input} is: {reverse}");
            Console.ReadLine();
        }

        public void CharactorCountInStirng()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int count = 0;
            foreach (char ch in input)
            {
                if (ch != 32)
                {
                    count++;
                }          
            }
            Console.WriteLine($"The count of charactor in string is: {count}");
            Console.ReadLine();
        }

        public void WordsCountInString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int count = 0;
            foreach (char ch in input)
            {
                if (count == 0)
                {
                    count = 1;
                }
                if (ch == 32)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"The count of word in string is: {count}");
            Console.ReadLine();
        }

        /// <summary>
        /// Removing the extra sequencing of spaces from string like:  I         like       mango
        /// </summary>
        public void WordsCountInString1()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int count = 0; bool  Flag = true;
            foreach (char ch in input)
            {
                if (ch == 32 && Flag == false)
                {
                    continue;
                }
                else
                {
                    Flag = true;
                }
                if (count == 0)
                {
                    count = 1;
                }
                if (ch == 32)
                {
                    count += 1;
                    Flag = false;
                }
            }
            Console.WriteLine($"The count of word in string is: {count}");
            Console.ReadLine();
        }     

        //Write the program for Copy string
        public void CopyString()
        {
            Console.Write("Enter string1: ");
            string input = Console.ReadLine();

            int Length = 0;
            foreach (Char ch in input)
            {
                Length++;
            }
            char[] arr = new char[Length];

            int index = 0;
            foreach (Char ch in input)
            {
                arr[index] = ch;
                index++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= arr.Length -1; i++)
            {
                sb.Append(arr[i]);
            }

            Console.WriteLine(sb);
            Console.ReadLine();
        }

        //program to count the number of vowels or consonants in a string.
        public void CountVowelsConsonants()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            
           int intLength = str.Length;

            int VowelCount = 0; int ConsonentCount = 0;

            for(int i = 0; i < intLength; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    VowelCount++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    ConsonentCount++;
                }              
            }
            Console.WriteLine($"Count of Vowels are: {VowelCount} and Count of Consonent are: {ConsonentCount}");
            Console.ReadLine();
        }

        // Find maximum occurring character in a string

        public void MaxOccurchar()
        {
            Console.Write("Enter a string: ");
            string strInput =  Console.ReadLine();
        }
    }
}
