using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Store; // using namespace Store

namespace Lad_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gán giá trị
            dealer.Name = "Coca cola";
            dealer.Email = "cocacolap@gmail.com";
            dealer.Phone = "(111)791-8074";
            //in thông tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);
            //tạo mới sản phẩm nằm trong namespace Store
            StoreItem si = new StoreItem();
            //gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 80.00M;
            //in thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #: ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name: ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price: ");
            Console.WriteLine(si.Price);
            Console.Read();

        }
    }
}
