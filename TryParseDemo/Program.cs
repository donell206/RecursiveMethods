﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Parse


            try
            {
                int intNumber = int.Parse("123");
                Console.WriteLine(intNumber);
            }
            catch (Exception)
            {

                Console.WriteLine(" Not a valid number");
            }

            //int intNumber = int.Parse("123");
            //long longNumber = long.Parse("123");
            //bool status = bool.Parse("false");
            //decimal decNumber = decimal.Parse("123.5");

            //Console.WriteLine(intNumber);
            //Console.WriteLine(longNumber);
            //Console.WriteLine(status);
            //Console.WriteLine(decNumber);

            #endregion


            #region TryParse

            //int parsedInt = 0;
            //Console.WriteLine("Give a number pls...");
            //string input = Console.ReadLine();
            //bool isNumber = int.TryParse("q12f3", out parsedInt);

            //if (isNumber)
            //{
            //    Console.WriteLine(" Valid Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Valid Number");
            //}


            #endregion




        }
    }
}
