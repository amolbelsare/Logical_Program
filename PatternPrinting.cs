using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    public class PatternPrinting
    {    
            //1
            //22
            //333
            //4444
            //55555
        public void Patten1()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i=1; i <= num; i++)
            {
                for (int j=1; j <= i; j++)
                {
                    Console.Write(i);
                }    
                Console.WriteLine();
            }
            Console.ReadLine();
        }
                //*
                //**
                //***
                //****
                //*****
        public void Patten2()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
                //1
                //12
                //123
                //1234
                //12345
        public void Patten3()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
                 
                //5
                //54
                //543
                //5432
                //54321
        public void Patten4()
        {
            Console.Write("Enter a number: ");
            int Number = int.Parse(Console.ReadLine());

            int i = Number;
            while (i >= 1)
            {
                int j = Number;
                while (j >= i)
                {
                    Console.Write(j);
                    j--;
                }
                Console.WriteLine();
                i--;
            }
            Console.ReadLine();
        }

        //By using for loop
        public void Patten4_1()
        {
            Console.Write("Enter a Numebr: ");
            int Number = int.Parse(Console.ReadLine());

            for (int i = Number; i >= 1; i--)
            {
                for (int j = Number; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
               
                //1
                //2 3
                //4 5 6
                //7 8 9 10
                //11 12 13 14 15
        public void Patten5() 
        {
            Console.Write("Enter Numbers of rows: ");
            int Number = int.Parse(Console.ReadLine());

            int x = 0;
            for (int i = 1; i <= Number; i++)
            {
                for (int j=1; j<= i; j++)
                {
                    x++;
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine() ;
        }
               
                //1
                //01
                //101
                //0101
                //10101
        public void Patter6()                           //Solution => if i is odd => 0 1
        {                                                           //if i is even => 1 0
            Console.Write("Enter Numbers of rows: ");
            int Number = int.Parse(Console.ReadLine());

            int x = 0, y = 0;
            for (int i=1; i<=Number; i++)
            {
                if (i % 2 == 0)
                {
                    x = 1;
                    y = 0;
                }
                else
                {
                    x = 0;
                    y = 1;
                }
                for(int j=1; j<=i; j++)
                {
                    if (j%2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(y);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine() ;

        }

                //1
                //12
                //123
                //1234
                //12345
                //12345
                //1234
                //123
                //12
                //1
        public void Patten7()
        {
            Console.Write("Enter Numbers of rows: ");
            int Number = int.Parse(Console.ReadLine());

    
            for (int i = 1; i <= Number; i++)
            {
                for (int j = 1; j <= i; j++)
                {               
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = Number; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

                //1234
                //123
                //12
                //1

                //1
                //12
                //123
                //1234
                //12345
        public void Patter8()
        {
            Console.Write("Enter the number: ");
            int Num = int.Parse(Console.ReadLine());

            for(int i = Num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= Num; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

            //    1
            //   121
            //  12321
            // 1234321
            //123454321

        public void Patter9()
        {
            Console.Write("Enter the Number: ");
            int Num = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i=1; i<=Num; i++)
            {
                for (int space=1; space <=(Num - i); space++)
                {
                    Console.Write(" ");
                }
                for (int j =1; j<=i; j++)
                {
                    Console.Write(j);
                }
                for(int k =(i-1); k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

                 //        1
                 //       1 1
                 //      1 2 1
                 //     1 3 3 1
                 //    1 4 6 4 1
                 //   1 5 10 10 5 1
                 //  1 6 15 20 15 6 1
                 // 1 7 21 35 35 21 7 1
                 //1 8 28 56 70 56 28 8 1
         
        public void patter10() 
        {
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());
            Console.Clear();

            int j, k;
            for(int i=0; i<=Num;i++)
            {
                k = 1;
                for (j=i; j<= Num; j++)
                {
                    Console.Write(" ");
                }
                for (j=0; j<=i; j++)
                {
                    Console.Write(k + " ");
                    k = (k * (i - j) / (j + 1));
                }
                Console.WriteLine() ;
            }
            Console.ReadLine();
        }

             //      *
             //     ***
             //    *****
             //   *******
             //  *********
             // ***********
             //*************
             //*************
             // ***********
             //  *********
             //   *******
             //    *****
             //     ***
             //      *
        public void patten11()
        {
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());

            int count = Num - 1;
            for (int i =1; i<Num + 1; i++)
            {
                for (int j = 1; j<=count; j++)
                {
                    Console.Write(' ');
                }
                count--;
                for (int j=1;j<=2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                              
            }
            count = 1;
            for (int i = 1; i<= Num - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int j = 1; j <= 2 * (Num - i) -1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

                //* *
                //** **
                //*** ***
                //**** ****
                //***** *****
                //****** ******
                //******* *******
                //******** ********

        public void Patten12()
        {
            Console.Write("Enter number of rows: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i<num; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                if (i < num)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine ();
        }

            //********
            //*      *
            //*      *
            //*      *
            //*      *
            //*      *
            //*      *
            //********

        public void Patten13()
        {
            Console.Write("Enter number of rows: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if(i == 0 || i== num -1)
                {
                    for(int j =0; j < num; j++)
                    { 
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int j=0; j<num; j++)
                    {
                        if(j ==0 || j== num -1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
