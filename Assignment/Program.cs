using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1
            //Console.WriteLine("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());

            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.Write(i);
            //        if (i < num)
            //        {
            //            Console.Write(", "); // علشان نضيف فاصلة 
            //        }
            //    }
            //    Console.WriteLine(); 

            #endregion
            #region Q 2
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());

            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(num * i); 
            //        if (i < 12)
            //        {
            //            Console.Write(", "); 
            //        }
            //    }
            //    Console.WriteLine(); 

            #endregion
            #region Q 3

            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{

            //    if (i % 2 == 0 && i < num - 1)
            //    {

            //        Console.Write(i);
            //        Console.Write(", ");

            //    }
            //}
            //Console.WriteLine(); 

            #endregion
            #region Q 4
            //Console.WriteLine("Enter Base : ");
            //int basenum = int.Parse(Console.ReadLine());

            //Console.Write("Enter Exponent : ");
            //int exponentnum = int.Parse(Console.ReadLine());
            #endregion
            #region Q 5 (Note : Search when u finish Not Solved Yet)
            
            #endregion
            #region Q 7
            Console.WriteLine("Enter a number for convert: ");
            int decimalNumber = int.Parse(Console.ReadLine());


            string binaryResult = " ";


            while (decimalNumber > 0)
            {

                binaryResult = (decimalNumber % 2 == 0) + binaryResult;

                decimalNumber = decimalNumber / 2;
            }

            Console.WriteLine($"The Binary of  + {decimalNumber} +  is  + {binaryResult}");
            #endregion
            #region Q 8
            //Console.Write("Enter the value of (n)  :  ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = 0; j < n; j++)       // loop in loop
            //    {

            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion
            #region Q 9
            //Console.Write("Enter a string : ");
            //string inputString = Console.ReadLine();


            //Console.Write("Enter the starting index : ");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of the substring : ");
            //int length = int.Parse(Console.ReadLine());

            //string substring = inputString.Substring(startIndex, length);

            //Console.WriteLine("The substring is: " + substring);
            #endregion
            #region Q 10
            //Console.Write("Enter the first string: ");
            //string firstString = Console.ReadLine();

            //Console.Write("Enter the second string: ");
            //string secondString = Console.ReadLine();

            //string BothString = firstString + secondString;

            //Console.WriteLine("The combined string is: " + BothString);
            #endregion
            #region Q 12
            //Console.WriteLine("Enter The Number of Elements : ");
            //int Number = int.Parse(Console.ReadLine());

            //int Sum = 0;

            //for (int i = 0; i < Number; i++)
            //{
            //    Sum += int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine($"The Sum of Elements is :{Sum}");
            #endregion

        }
    }
}
