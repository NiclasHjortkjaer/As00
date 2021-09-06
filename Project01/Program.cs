using System;

namespace Project01
{
    public class Program
    {

        public static void Main(String[] args){
            string input = args[0];
            try{
                int year = int.Parse(input);
                if(IsLeapYear(year))
                    Console.WriteLine("yay");
                else
                    Console.WriteLine("nay");
            } catch(FormatException){
                Console.WriteLine("Please only input integers");
            }
        }

        public static bool IsLeapYear(int year){
            if(year % 100 == 0 && year % 400 != 0 || year < 1582)
                return false;
            else if (year % 4 == 0)
                return true;
            else 
                return false;
        }
    }
}
