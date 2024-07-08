using System;

namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Thuật ngữ: native, OUT RANGE, Template String, Defautlt
             * 1. Kiểu dữ liệu:
             * Kiểu dữ liệu native
             * Kiểu số nguyên: int, long, short
             * Số thực: float, double, decimal | khi mà vượt quá Max của 1 kiểu dữ kiểu dữ liệu: OUT RANGE
             * Kiểu Char (Ký tự): char => Split (Cắt chuỗi) | Split(',')
             * Kiểu chuỗi string (Một mãng của char): 
             * Kiểu boolean (kiểu điều kiện) chỉ có 2 giá trị: true | false;
             * 2. Các khai báo biến: `Kiểu dữ liệu` `tên biến (camelCase)`
             */


            int a = 10;
            int b = 5;
            bool isEqual = (a == b);
            bool isNotEqual = (a != b);
            bool isGreater = (a > b);
            bool isLesser = (a < b);
            bool isGreaterOrEqual = (a >= b);
            bool isLesserOrEqual = (a <= b);

        }
    }
}