using System;

namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log2();
            Log2();
        }
        //Phương thức (Method) != Hàm (Function)

        /*
         * Trường hợp không trả về gì thì kiểu dữ liệu sẽ là _void_
            Syntax:
               Phạm vi | Vòng đời (Optional) | Kiểu dữ liệu trả về | Tên hàm (Tham số(Params)) {Nội dung code}
            VD:
               private static void Print(string text) {Nội dung code}
            Cách sử dụng:
                Gọi tên hàm và truyền giá trị (nếu có)
         */
        public static void Log1()
        {
            Console.WriteLine(1);
        }

        public static bool IsChanLe(int number)
        {
            return number % 2 == 0;
        }
        public static void Log2()
        {
            int a = 1;
            a++;
            Console.WriteLine(a);
        }
    }
}