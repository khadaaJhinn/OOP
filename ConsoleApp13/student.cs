using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp13.Program1;

namespace ConsoleApp13
{
    internal class Program1 
    {
        public class Student
        {
            private string studentId;
            private string name;
            private int birthYear;
            private bool gender;
            private string stdClass;


            public Student() { }
            public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
            {
                this.studentId = studentId;
                this.name = name;
                if (birthYear >= 1900 && birthYear <= DateTime.Now.Year)
                    this.birthYear = birthYear;
                this.gender = gender;
                this.stdClass = stdClass;
            }
            public string GetStudentId()
            {
                return this.studentId;
            }
            public void SetStudentId(string newId)
            {
                this.studentId = newId;
            }
            public string GetName()
            {
                return this.name;
            }
            public void SetName(string newName)
            {
                this.name = newName;
            }
            public int GetBirthYear()
            {
                return this.birthYear;
            }
            public void SetBirthYear(int newbirthYear)
            {
                this.birthYear = newbirthYear;
            }
            public bool GetGender()
            {
                return this.gender;
            }
            public void SetGender(bool newGender)
            {
                this.gender = newGender;

            }
            public string GetStdClass()
            {
                return this.stdClass;
            }

            public void SetStdClass(string newStdClass)
            {
                this.stdClass = newStdClass;
            }
            public void Input()
            {
                Console.WriteLine("nhap thong tin sinh vien ");
                Console.Write("nhap ID");
                this.studentId = Console.ReadLine();
                Console.Write("nhap ten ");
                this.name = Console.ReadLine();
                Console.Write("nhap nam sinh");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x >= 1900 && x <= DateTime.Now.Year)
                {
                    this.birthYear = x;
                    Console.Write($"{x} ");
                }
                else
                {
                    Console.WriteLine("khong ton tai");
                }

                Console.Write("nhap gioi tinh (o la nu , 1 la nam , 2 la be de) ");
                if (Console.ReadLine() == "0")
                    this.gender = false;
                else
                    this.gender = true;
                Console.Write("nhap class");
                this.stdClass = Console.ReadLine();


            }


            public void PrintInfo()
            {
                Console.WriteLine("Student ID: " + this.studentId);
                Console.WriteLine("Ten sv:" + this.name);
                Console.WriteLine("Nam Sinh:" + this.birthYear);
                Console.WriteLine("Gioi Tinh:" + this.gender);
                Console.WriteLine("Lop Hoc:" + this.stdClass);
            }
        }
       

    }
    
}
