using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // CLass
    // Props || Property
    // Method
    /*
        Cấu trúc
        Phạm vi | class | Tên của class {Nội dung}
     */

    public class Car
    {
        // Hàm khởi tạo constructor
        public Car(string tenXe, int soLuongBanhXe, double trongTai)
        {
            this.TenXe = tenXe;
            this.SoLuongBanhXe = soLuongBanhXe;
            this.TrongTai = trongTai;
        }

        //Cấu trúc syntax của props
        public string TenXe { get; set; }
        public int SoLuongBanhXe { get; set; }
        public double TrongTai { get; set; }

        public void Run()
        {
            Console.WriteLine("Xe dang chay");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ten xe: {this.TenXe}");
            Console.WriteLine($"So luong banh xe: {this.SoLuongBanhXe}");
            Console.WriteLine($"Trong tai: {this.TrongTai}");
        }
    }
}
