using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessBar
{
    public class Process
    {
        private int total;
        private int progress;
        private int barLength;

        public Process(int total, int barLength = 50)
        {
            this.total = total;
            this.progress = 0;
            this.barLength = barLength;
        }

        public void Update(int value)
        {
            progress = value;
            Draw();
        }

        private void Draw()
        {
            Console.CursorLeft = 0;
            float percent = (float)progress / total;
            int chars = (int)Math.Round(percent * barLength);

            StringBuilder bar = new();
            bar.Append('[');
            for (int i = 0; i < barLength; i++)
            {
                if (i < chars)
                {
                    bar.Append('=');
                }
                else
                {
                    bar.Append(' ');
                }
            }
            bar.Append("] ");
            bar.AppendFormat("{0,3:##0}%", percent * 100);

            Console.Write(bar.ToString());
        }

        public void Finish()
        {
            Update(total);
            Console.WriteLine();
        }
    }
}
