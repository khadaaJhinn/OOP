using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp15
{


    public abstract class ConVat
    {
        protected string mauSac;
        protected double canNang;
        protected int soChan;
        protected bool hungDu;



        public ConVat() { } 
        public ConVat(string mauSac,double canNang, int soChan , bool hungDu)
        {
            this.mauSac = mauSac;
            this.canNang = canNang;
            this.soChan = soChan;
            this.hungDu = hungDu;
        }

        public string getMauSac()
        {
            return this.mauSac;
        }
        public void setMauSac(string mauSac)
        {
            this.mauSac= mauSac;
        }
        public double getCanNang()
        {
            return this.canNang;
        }

        public void setCanNang(double canNang)
        {
            this.canNang= canNang;
        }
        public virtual void Keu()
        {
            Console.WriteLine(".");
        }
        public virtual string getVuKhi()
        {
            return (this.mauSac).ToString();    
        }

        public virtual void InPut()
        {
            Console.WriteLine("nhap mau sac");
            this.mauSac = Console.ReadLine();
            Console.WriteLine("nhap can nang");
            this.canNang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so chan");
            this.soChan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hung du :true || Khong Hung Du :false ");
            this.hungDu = Convert.ToBoolean(Console.ReadLine());
        }


        
        

        


    }

  
    
}
