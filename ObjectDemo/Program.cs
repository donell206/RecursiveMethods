using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            //object obj = new object();
            //obj.ToString();

            //int x = 10;
            //decimal d = 102.50m;
            //object obj = 10;

            //obj = "Hello";
            //Console.WriteLine(obj);
            //obj = 15.50m;
            //Console.WriteLine(obj);


            //Console.WriteLine(d.ToString());
            //Console.WriteLine(x.ToString());
            //x++;
            //Console.WriteLine(x.ToString());

            #endregion

            byte b = 10;
            int pnumber = 321225627;
            long 1 = money;
            //b = (byte)pnumber;
            decimal d = 105.564m;
            decimal d1 = 0;
            object o = x;            //  BOXING
            object obj = 50;         //  BOXING

            x = (int)obj;  // unboxing naar een Object - eigenlijk 
            d1 = (int)obj;  // unboxing 

            Console.WriteLine(x);


        }
    }
}
