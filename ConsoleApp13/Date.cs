using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Date
    {
        private int day;
        private int year; 
        private int month;

       public Date() { }
        public Date(int day, int year, int month)
        {
            if(day > 0  && day < 31)
            {
                this.day = day; 
            }
            if (month > 0 && month < 12)
            {
                this.month = month; 

            }
            if (year > 1990 &&  year < 9999)
            {
                this.year = year; 
            }
        }

        public int getDay()
        {
            return this.day; 

        }
        public int getMonth()
        {
            return this.month;
        }
        public int getYear()
        {
            return this.year;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }
        public void SetMonth(int month)
        {
            this.month = month; 
        }
        public void SetYear(int year)
        {
            this.year = year; 
        }
        public void SetDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public  override string ToString() 
        {

            return String.Format("{0:00}", this.day) + "/" + String.Format("{0:00}", this.month) + "/" + String.Format("{0:00}", this.year);
        }

        public void Input()
        {
            Console.WriteLine("Nhap gia tri ngay");
            this.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri thang");
            this.month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri nam");
            this.year= Convert.ToInt32(Console.ReadLine());
        }
    }

}
