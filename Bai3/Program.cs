using System;

namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                 if(Câu điều kiện) {Nội dung code}
                 else if (Câu điều kiện) {Nội dung code}
                 else {Nội dung code}
             */

            int tuoi = 18;

            if (tuoi == 18)
            {
                //Nội dung sẽ hiển thị nếu câu điều kiện là đúng
                Console.WriteLine("Đủ tuôi xem phim");
            }
            else if (tuoi < 18)
            {

            }
            else
            {

            }

            /*
                Cấu trúc:
                    switch(Cái cần so sánh) {
                        case (Cái để so sánh):
                            break;
                        default:
                            break;
                    }
             */

            int phanKhoi = 150;

            switch (phanKhoi)
            {
                case 150:
                    Console.WriteLine($"Phan khoi: 150");
                    break;
                case 200:
                    Console.WriteLine($"Phan khoi: 200");
                    break;
                case 300:
                case 400:
                    Console.WriteLine("Phân khối 300 và 400");
                    break;
                default:
                    break;
            }

            /*
                Cấu trúc:
                    for(int i = số bắt đầu; điều kiện kết thúc vòng lập; i++) {Nội dung code}
                *Lưu ý: i có thể đặt tên tùy thích miễn có đủ ngữ nghĩa
                *Giải thích ngữ nghĩa cấu trúc
                 for là syntax
                 int i = ... là initial value
                 i < ... hoặc điều kiện nào đó; điều kiện kết thúc vòng lặp
                i++ là bước nhảy của vòng lặp
             */



            /*
                Cấu trúc:
                    while (điều kiện kết thúc) {Nội dung code}
             */
            bool isSuccess = true;
            int i = 9;

            while (i > 9)
            {
                i++; // i = i + 1 => i = 1 // lần lặp thứ 10 
                if (i == 10)
                {
                    isSuccess = false;
                    Console.WriteLine("Dung vong lap");
                }
                Console.WriteLine("A");
            }

            /*
                Cấu trúc:
                    do {Nội dung code}
                    while(Điều kiện dừng)
             */

            // Validate Data || Validate Values: isValid = nếu dự đúng || isInValid

            int a = 0;
            int b = 0;
            bool isValid = false; // sai
            do
            {
                if (b < 18 || !isValid)
                {
                    Console.WriteLine("M nhap sai r nhap lai di: ");
                }
                Console.Write("Nhap b: ");
                isValid = int.TryParse(Console.ReadLine(), out b); // a 

            } while (b < 18 || !isValid); // false

        }
    }
}