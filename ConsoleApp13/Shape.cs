using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public abstract class Shape 
    {
       
        protected string color;
        protected  bool filled;

        public Shape() { } 
        public Shape(string color , bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string getColor()
        {
            return color; 
        }
        public void setColor(string Color ) 
        {
            this.color=Color;
            
        }
        public bool isFilled()
        {
            return this.filled;
        }
        public  void setFilled(bool Filled)
        {
            this.filled = Filled;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public virtual String toString()
        {
            return (this.color + " " + this.filled);
        }
        public void Input()
        {
            
            Console.WriteLine("nhap mau");
            this.color = Console.ReadLine();
            Console.WriteLine(" filled : tru / none_fill : false");
            this.filled = Convert.ToBoolean(Console.ReadLine()); 
        }

        
        

    }
    public  class Circle : Shape
    {
        protected double radius;

        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color , bool filled)
        {
            this.radius=radius;
            this.color = color;
            this.filled = filled;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public void setRadius(double Radius)
        {
            this.radius = Radius;
        }
        public override double getArea()
        {
            return this.radius * this.radius * Math.PI; 
        }
        public override double getPerimeter()
        {
            return this.radius* 2  * Math.PI; 
        }
        public override string ToString()
        {
           return  ("Circle" + " " + this.color + " " + this.filled + " " + radius);
        }

        public void InPut()
        {
            Console.WriteLine("nhap mau");
            this.color = Console.ReadLine();
            Console.WriteLine(" filled : tru / none_fill : false");
            this.filled =Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("nhap ban kinh");
            this.radius = Convert.ToInt32(Console.ReadLine());
        }

        


    }
    public  class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle() { }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
as        public Rectangle(double width , double length, string color, bool filled)
        {
            this.width = width;
            this.length = length;
            this.color = color;
            this.filled = filled;

        }
        public double getWidth()
        {
            return this.width;
        }
        public void setWidth(double Width)
        {
            this.width =Width;
        }
        public double getLength()
        {
            return this.length;
        }
        public void setLength(double Length)
        {
            this.length =Length;
        }
        public override double getArea()
        {
            return this.width* this.length; 
        }
        public override double getPerimeter()
        {
            return (this.width + this.length) * 2;
        }
        public override string ToString()
        {
            return ("Rectangle" + " " + this.color + " " + this.filled + " " + width + " " + length);
        }

        public  void InPut()
        {

            Console.WriteLine("nhap mau");
            this.color = Console.ReadLine();
            Console.WriteLine(" filled : tru / none_fill : false");
            this.filled = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("nhap chieu rong");
            this.width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap chieu dai ");
            this.length = Convert.ToInt32(Console.ReadLine());
        }






    }

    public class Square : Rectangle
    {
        protected double side;
        public Square() { } 
        public Square(double side )
        {
            this.side = side; 
        }
        public Square(double side , string color , bool filled)
        {
            this.side = side;
            this.color = color;
            this.filled = filled;

        }
        public double getSide()
        {
            return this.side;
        }
        public void setSide(double side)
        {
            this.side = side; 
        }
        public override double getArea()
        {
            return side * side; 
        }
        public override double getPerimeter()
        {
            return (side * 4); 
        }
        public override string toString()
        {
            return ("Square" + " " + this.color + " " + this.filled + " " + side);
        }

        public void InPut()
        {
            Console.WriteLine("nhap mau");
            this.color = Console.ReadLine();
            Console.WriteLine(" filled : tru / none_fill : false");
            this.filled = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("nhap chieu dai canh hinh vuong");
            this.side = Convert.ToInt32(Console.ReadLine());

        }
    }
}
