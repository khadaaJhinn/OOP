using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Caculator
    {
        public int Add(int a , int b)
        {
            return a + b;
        }
        public double Add(double a , double b)
        {
            return (double)a + (double)b; 
        }
        public int Subtract(int a , int b)
        {
            return a - b;
        }
        public double Subtract(double a , double b)
        {
            return (double)a - (double)b; 
        }
        public int Multiply (int a , int b)
        {
            return a * b; 
        }
        public double Muiltiply(double a , double b)
        {
            return (double)(a * b); 
        }
        public double Divide(int a , double b)
        {
            return a / b;
        }
        public double Divide ( double a , double b )
        {
            return (double)(a / b);
        }
        public int Min (int a , int b)
        {
            int Min = a;
            if (a > b)
            {
                 Min = b;
            }
           
              return Min;
        }
        public int Min1 (int a , int b , int c)
        {

            int Min = a;
            if (Min > b)
            {
                 Min = b;
            }
            else if (Min > c )
            {
                Min = c;
            }
            return Min; 
        }
        public double Min2(double a , double b, double c)
        {
            double Min = a;
            if (a > b)
            {
                 Min = b;
            }
            if (b > c)
            {
                Min = c;
            }
            return Min;
        }
        public int Max( int a , int b)
        {
            int Max = a;
            if(a < b)
            {
                 Max = b;
            }

            return Max;
        }
        public int Max1(int a , int b, int c)
        {
            int Max = a; 
            if(a < b)
            {
                 Max = b; 
            }
           if (b < c)
            {
                 Max = c;
            }
            return Max;
            
        }
        public double Max2(double a , double b, double c)
        {
            double Max = a;
            if (Max < b)
            {
                 Max = b; 
            }
             if (Max< c)
            {
                 Max = c;
            }
            return Max; 
        }






       
    }
}
