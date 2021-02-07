using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Triangle
    {
        int x;
        int y;
        int z;
        void ShowInfo()
        {
            Console.WriteLine("X :" + x);
            Console.WriteLine("Y :" + y);
            Console.WriteLine("Z :" + z);
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        
    }
}
}
