using ConsoleApp13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program1
{
    static void Main(string[] args)
    {
        //Fraction PhanSo1 = new Fraction(1, 2);
        //Fraction Phanso2 = new Fraction(3, 4);
        //Fraction Phanso3 = PhanSo1.Add(Phanso2);
        //Phanso3.Simplify();

        //Console.WriteLine(Phanso3.ToString());

        //Circle n = new Circle();
        //n.getPerimeter(); 


        Rectangle n = new Rectangle(); 
        n.InPut();
        double dientich = n.getArea();
        Console.WriteLine(n.ToString());
        Console.WriteLine(dientich);







    }
}