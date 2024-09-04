using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    
    
        public class ConMeo : ConVat
        {
            public string nguonGoc;
            public int tuoi;


            public ConMeo() { }
            public ConMeo(string nguonGoc, int tuoi)
            {
                this.nguonGoc = nguonGoc;
                this.tuoi = tuoi;
            }
            public ConMeo(string nguonGoc, int tuoi, string mauSac, double canNang, int soChan, bool hungDu)
            {
                this.nguonGoc = nguonGoc;
                this.tuoi = tuoi;
                this.canNang = canNang;
                this.mauSac = mauSac;
                this.soChan = soChan;
                this.hungDu = hungDu;
            }





            public override void Keu()
            {
                Console.WriteLine("Meo Meo");
            }

            public override string getVuKhi()
            {
                return ("mong gio");
            }

            public override void InPut()
            {
                base.InPut();

                Console.WriteLine("nhap nguon goc");
                this.nguonGoc = Console.ReadLine();
                Console.WriteLine("nhap tuoi");
                this.tuoi = Convert.ToInt32(Console.ReadLine());
            }





        }

    
}
