using System;
using System.Threading;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Animal choPhoc = new Cho();
            choPhoc.Ten = "Phoc1";
            choPhoc.soLuongChan = 4;

            choPhoc.Info();

            Animal vitXiem = new Vit();
            vitXiem.Ten = "Phoc1";
            vitXiem.soLuongChan = 4;

            vitXiem.Info();

            Animal a = new Animal();
            bool isCho = false;
            if (isCho)
            {
                Cho cho = new Cho();
            }
            else
            {
                a = new Vit();
            }
        }
    }
}
