using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    
    
        public class ConCho : ConVat
        {
            public string xuatXu;
            public int luongThucAn;

            public ConCho() { }
            public ConCho(string xuatXu, int luongThucAn)
            {
                this.xuatXu = xuatXu;
                this.luongThucAn = luongThucAn;
            }

            public ConCho(string mauSac, double canNang, int soChan, bool hungDu)
            {
                this.mauSac = mauSac;
                this.canNang = canNang;
                this.soChan = soChan;
                this.hungDu = hungDu;
            }

            public override void Keu()
            {
                Console.WriteLine("gau gau");

            }
            public override string getVuKhi()
            {
                return this.getVuKhi();
            }


            public override void InPut()
            {
                base.InPut();
                Console.WriteLine("nhap xuat xu");
                this.xuatXu = Console.ReadLine();
                Console.WriteLine("nhap luong thuc an");
                this.luongThucAn = Convert.ToInt32(Console.ReadLine());
            }


        }
    
}
