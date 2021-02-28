using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Program
    {
        static void Main(string[] args)
        {
            Depertment d1 = new Depertment("Computer science", "CS");
            Depertment d1 = new Depertment("Electrical ENGG", "EEE");
            Student s1 = new student("Arifur Rahman", "18-38852-3", "3.5f");
            Student s2 = new student("Arif", "18-38852-3", "2.5f");


            d1.AddStudent(s1);
            d2.AddStudent(s2);

        }



    }
}
