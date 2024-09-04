using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Author
    {

        private string name;
        private string email;
        private char gender;


        public Author() { }
        public Author(string name, string email, char gender)
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
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public char GetGender()
        {
            return this.gender;
        }
        public  virtual string ToString()
        {
            return String.Format($"Author={this.name}  \n-email={this.email} , \n-gender={this.gender} ");
        }
        public  virtual void InPut()
        {
            Console.WriteLine("nhap ten tac gia ");
            this.name = Console.ReadLine();
            Console.WriteLine("nhap gmail tac gia ");
            this.email = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh ");
            this.gender =  Convert.ToChar(Console.ReadLine()); 

        }

    }
class Book : Author
{
    private string name;
    private Author author;
    private double price;
    private int qty = 0;


    public Book() { }
    public Book(string name, Author author, double price)
    {
        this.name = name;
        this.author = author;
        this.price = price;



    }
    public Book(string name, Author author, double price, int qty)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qty = qty;
    }
    public string GetName()
    {
        return name;
    }
    public Author GetAuthor()
    {
        return author;
    }
    public double GetPrice()
    {
        return price;
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public int GetQty()
    {
        return qty;
    }
    public void SetQty(int qty)
    {
        this.qty = qty;
    }
    public override string ToString()
    {
        
   
    

        return $"-{base.ToString()}   \n-Book={this.name}  \n-Author={this.name}  \n-price={this.price}  \n-qty={this.qty} "; 
    }
    public override void InPut()
    {
        base.InPut();
        Console.WriteLine("nhap ten sach");
        this.name = Console.ReadLine(); 
        Console.WriteLine("nhap gia ");
        this.price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap so luong");
        this.qty = Convert.ToInt32(Console.ReadLine());

    }
   



}