using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Vit : Animal
    {
        public override void Info()
        {
            Console.WriteLine($"Ten Vit: {this.Ten}, SoChanVit: {this.soLuongChan}");
        }
    }
}
