using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class SalesDetails
    {
        int SalesNo;
        int ProductionNo;
        int Prize;
        int DateOfSale;
        int Qty;


        public int TotalAmount;
        public void sales()
        {
            int Qty, Prize;
            Console.WriteLine("enter the Qty");
            Qty = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Prize");
            Prize = int.Parse(Console.ReadLine());
            TotalAmount = Qty * Prize;
        }
        public SalesDetails(int SalesNo, int ProductionNo, int Qty, int DateOfSale, int Prize)
        {
            this.SalesNo = SalesNo;
            this.ProductionNo = ProductionNo;
            this.Prize = Prize;
            this.Qty = Qty;
            this.DateOfSale = DateOfSale;
            
        }
        public void Displaysalesdetails()
        {
            Console.WriteLine($"Qty : {Qty},SalesNO : {SalesNo},ProductionNo : {ProductionNo},Prize : {Prize}, DateOfSale : {DateOfSale},TotalAmount : {Qty * Prize}");
            Console.Read();
        }

        static void Main()
        {
            SalesDetails s = new SalesDetails(12, 123, 6, 6, 24);
            s.Displaysalesdetails();
        }
    }
}

        

    

