using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SingleTonClass singleTon = SingleTonClass.GetInstance();

            Logics logics = new Logics();


            logics.FindEvenOddList();
            //logics.OddNumberRange();
            //logics.FibanocciSerise();
            //logics.PalindromeNumber();
            //logics.factorial();
            //logics.CheckArmstrongNumber();
            //logics.SumofAllNumbers();
            //logics.SwappingTwoNum();
            //logics.NumberToString();
            //logics.LargetNumberFromArray();
            //logics.LeafYear();
            //logics.NumberToBinary();
            //logics.ReverseNumber();
            //logics.LeafYear();
            //logics.Print1To100();
            //logics.FindGCD();


            StringManupulation str = new StringManupulation();
            //str.CountVowelsConsonants();
            //str.CopyString();
            //str.DuplicateChar();
            //str.charToArray();
            //str.UniqueChars();
            //str.StringLength();
            //str.StringReverse();
            //str.CharactorCountInStirng();
            //str.WordsCountInString();


            PatternPrinting pt = new PatternPrinting();
            //pt.Patten1();
            //pt.Patten2();
            //pt.Patten3();
            //pt.Patten4();
            //pt.Patten4_1();
            //pt.Patten5();
            //pt.Patter6();
            //pt.Patten7();
            //pt.Patter8();
            pt.Patter9();
            //pt.patter10();
            //pt.patten11();
            //pt.Patten12();
            //pt.Patten13();
        }
    }
}
