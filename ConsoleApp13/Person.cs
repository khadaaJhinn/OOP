using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{

    private string name;
    private int birthYear;
    private string address;

    public string Name
    {
        get { return name; }

        set { name = value; }
    }
    public int BirthYear
    {
        get { return birthYear; }

        set { birthYear = value; }
    }
    public string Address
    {
        get { return address; }

        set { address = value; }
    }
    public Person() { }
    public Person(string name, int birthYear, string address)
    {
        this.name = name;
        this.birthYear = birthYear;
        this.address = address;

    }


    public virtual void Input()
    {
        Console.WriteLine("nhap ho ten");
        this.name = Console.ReadLine();
        Console.WriteLine("nhap nam sinh");
        this.birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap dia chi");
        this.address = Console.ReadLine();




    }
    public int GetAge()
    {
        return DateTime.Now.Year - this.birthYear;
    }
    public  virtual string ToString()
    {
        return String.Format($" -HoTen:{this.name}  \n -NamSinh:{this.birthYear}  \n -DiaChi:{this.address}");
    }

}

class Student : Person
{
    private string program;
    private int year;


    public string Program
    {
        get { return program; }

        set { program = value; }
    }
    public int Year
    {
        get { return year; }

        set { year = value; }
    }
    public Student() { }
    public Student(string name, int birthYear, string address, string program, int year)
    {
        this.program = program;
        this.year = year;
    }
    public override void Input()
    {

        base.Input();
        Console.WriteLine("nhap chuong trinh hoc");
        this.program = Console.ReadLine();
        Console.WriteLine("nam hoc");
        this.year = Convert.ToInt32(Console.ReadLine());



    }
    public override string ToString()
    {
        return $"{base.ToString()} \n -Program:{this.program} \n -Year:{this.year}";

    }
    
    public void ChangeProgram(string program)
    {
        this.program=program; 
    }

}
class Staff : Person
{
    private string department;
    private double salary;

    public string Department
    {
        get { return department; }

        set { department = value; }
    }

    public double Salary
    {
        get { return salary; }

        set { salary = value; }
    }

    public Staff() { }
    public Staff(string name , int birthYear, string address,string department, double salary)
    {
        this.Salary = salary;
        this.Department = department;
       
    }
    public override void Input()
    {
        base.Input();
        Console.WriteLine("nhap khoa ");
        this.Department = Console.ReadLine();
        Console.WriteLine("nhap luong");
        this.Salary = Convert.ToInt32(Console.ReadLine());


    }
    public override string ToString()
    {
        return $"{base.ToString()} - Department:{this.Department} - Salary:{this.Salary}";

    }
    

}
