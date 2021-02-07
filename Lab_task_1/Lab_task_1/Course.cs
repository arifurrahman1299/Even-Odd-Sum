using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        void ShowCourseInfo()
        {
            Console.WriteLine("CourseName :" + courseName);
            Console.WriteLine("CourseCode :" + courseCode);
            Console.WriteLine("CourseCredit :" + courseCredit);
        }
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        
    }
}
