using System;

namespace Project01
{
    public class Program
    {

        public static void Main(String[] args){

        }

        public static bool IsLeapYear(int year){
            if(year % 100 == 0 && year % 400 != 0)
                return false;
            else if (year % 4 == 0)
                return true;
            else 
                return false;
        }
    }
}
