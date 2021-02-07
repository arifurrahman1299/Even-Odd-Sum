using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Account
    {
        string accName;
        string acId;
        int balance;

        void ShowCourseInfo()
        {
            Console.WriteLine("AccName :" + accName);
            Console.WriteLine("AcId :" + acId);
            Console.WriteLine("Balance :" + balance);
        }
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string AcId
        {
            get { return acId; }
            set { acId = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
