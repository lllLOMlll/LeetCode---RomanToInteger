using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
class Program
{

// Symbol       Value
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000

    public int RomanToInt(string s) {
        int total = 0;
        string[] romanArray = new string[s.Length]; 
        int i = 0;
       // Convert the string into an array
       foreach(char character in s)
       {
        romanArray[i] = character.ToString();
        i++;
       }

       for (int j = 0; j < romanArray.Length; j++)
       {
        if (romanArray[j] == "I")
        {
            total += 1;
        }
        // **** V  ****
        if (romanArray[j] == "V")
        {
            if (j > 0 && romanArray[j - 1] == "I") 
            {
            total += 3;
            } else {
            total += 5;
            }
        }
       // **** X  ****
        if (romanArray[j] == "X")
        {
            if (j > 0 && romanArray[j - 1] == "I")
            {
                total += 8;
            } else {
                total += 10;
            }
        }

        // **** L  ****
        if (romanArray[j] == "L")
        {
           if (j > 0 && romanArray [j - 1] == "X")
           {
            total += 30;
           } else {
            total += 50;
           }
        
        }

        // **** C  ****
        if (romanArray[j] == "C")
        {
            if (j > 0 && romanArray [j - 1] == "X")
            {
                total += 80; 
            } else {
                total += 100;
            }
        }
        // **** D  ****
        if (romanArray[j] == "D")
        {
            if (j > 0 && romanArray [j - 1] == "C")
            {
                total += 300;
            } else {
                total += 500;
            }
        }
        // **** M  ****
        if (romanArray[j] == "M")
        {
            if (j > 0 && romanArray [j - 1] == "C")
            {
                total += 800;
            } else {
                total += 1000;
            }
        }


       } //   for (int j = 0; j < romanArray.Length; j++)



         return total;
    }


static void Main(string[] args)
{
Program p = new Program();

int test = p.RomanToInt("III");
Console.WriteLine("III = 3 -> " + test);

int test2 = p.RomanToInt("VI");
Console.WriteLine("VI = 6 -> " + test2);

int test3 = p.RomanToInt("IV");
Console.WriteLine("IV = 4 -> " + test3);

int test4 = p.RomanToInt("XI");
Console.WriteLine("XI = 11 -> " + test4);

int test5 = p.RomanToInt("IX");
Console.WriteLine("IX = 9 -> " + test5);

// Tests supplémentaires

int test6 = p.RomanToInt("XX");
Console.WriteLine("XX = 20 -> " + test6);

int test7 = p.RomanToInt("XL");
Console.WriteLine("XL = 40 -> " + test7);

int test8 = p.RomanToInt("LXX");
Console.WriteLine("LXX = 70 -> " + test8);

int test9 = p.RomanToInt("XC");
Console.WriteLine("XC = 90 -> " + test9);

int test10 = p.RomanToInt("C");
Console.WriteLine("C = 100 -> " + test10);

int test11 = p.RomanToInt("CD");
Console.WriteLine("CD = 400 -> " + test11);

int test12 = p.RomanToInt("DCCC");
Console.WriteLine("DCCC = 800 -> " + test12);

int test13 = p.RomanToInt("CM");
Console.WriteLine("CM = 900 -> " + test13);

int test14 = p.RomanToInt("M");
Console.WriteLine("M = 1000 -> " + test14);

int test15 = p.RomanToInt("MCMXCIV");
Console.WriteLine("MCMXCIV = 1994 -> " + test15);

int test16 = p.RomanToInt("MMXXIII");
Console.WriteLine("MMXXIII = 2023 -> " + test16);

int test17 = p.RomanToInt("MMMCMXCIX");
Console.WriteLine("MMMCMXCIX = 3999 -> " + test17);

}

}