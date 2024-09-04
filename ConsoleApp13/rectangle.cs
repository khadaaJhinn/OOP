using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
     class Rectangle1
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return  height; }
            set { height = value; }
        }
        public Rectangle1() { }
        public Rectangle1(double width, double height)
        {
            if(Width > 0)
            {
                width = Width;
            }
            else
            {
                width = 1;
                Console.WriteLine("chieu rong khong phu hop");
            }
            if ( Height > 0)
            {
                height = Height; 
            }
            else
            {   height = 1;
                Console.WriteLine("chieu dai khong phu hop");
            }
            
            
               
        }
        public void  Input() 
        {
            do
            {

                Console.WriteLine("nhap gia tri chieu rong");
                Width = Convert.ToInt32(Console.ReadLine());
                
            }
            while (Width < 0  );
            do
            {
                Console.WriteLine("nhap gia tri chieu dai");
                Height = Convert.ToInt32(Console.ReadLine());
            }
            while (Height < 0 );

            
        }

        public override string ToString()
        {
            string KetQua ="kich thuoc hinh chu nhat la " + width + "x" + height;
            return KetQua;
        }
        public double GetPerimeter ()
        {
            return (width + height) * 2 ;
        }
        public double GetArea ()
        {
            return (width * height)  ;
        }
        public bool IsSameArea(Rectangle1 rect)
        {
            if (this.width + this.height == rect.width + rect.height) 
            return true;
            else
            {
                return false; 
            }
            
        }
       






    }
}
