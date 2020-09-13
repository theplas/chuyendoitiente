using System;

namespace bai1
{
    class Program
   {
        public  static  void  mustien () {
            int  vnd , usd = 1 ;
            vnd  =  usd  *  23000 ;
           Console.WriteLine("{0} USD = {1} VND ", usd, vnd);
            Console . Read ();

        }
        static void Main(string[] args)
        {
             int  usd ;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console . WriteLine ( " Enter the amount of USD you want to transfer: " );
            usd = Convert.ToInt32(Console.ReadLine());
           mustien ();
        
        }
    }
}