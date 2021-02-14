using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Programme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT ---\n");

            Student st = new Student();
            st.Name = "Arifur Rahman";
            st.Id = "18-38852-3";
            st.Cgpa = 3.34f;
            st.Department = " CSE";
            st.ShowInfo();

            Console.WriteLine("TRI-ANGLE---\n");

            Triangle tri = new Triangle();
            tri.X = 5;
            tri.Y = 5;
            tri.Z = 5;
            tri.ShowInfo();
            tri.TestTriangle();

            Console.WriteLine("COURSE---\n");

            Course co = new Course();
            co.CourseName = "C#";
            co.CourseCredit = 3;
            co.CourseCode = "CSC104";
            co.ShowCourseInfo();

            Console.WriteLine("ACCOUNT---\n");

            Account ac = new Account();
            ac.AccName = "FIx deposite ";
            ac.AcId = "ARA38852";
            ac.Balance = 10000;
            ac.Deposit(8000);
            ac.Withdraw(5000);

      

        }
    }
}
