using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Author
    {
        private string name;
        private string email;
        private char gender; 


        public Author() { }
        public Author (string name , string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;

        }
        public string GetName()
        {
            return this.name; 
        }
        public string GetEmail()
        {
            return this.email; 
        }
        public void SetEmail(string email )
        {
            this.email = email; 
        }
        public char GetGender()
        {
            return this.gender;
        }
        public string ToString()
        {
            return String.Format($"Author{this.name}= , {this.email}= , gender={this.gender} ");
        }
        public void InPut()
        {
            Console.WriteLine("nhap ten tac gia ");
            this.name = Console.ReadLine();
            Console.WriteLine("nhap gmail tac gia ");
            this.email = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh");

        }
    }
}
