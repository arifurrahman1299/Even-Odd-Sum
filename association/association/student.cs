using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string ID
        {
            get { return id; }
            set { id = value; }
        }
        private float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public student() { }
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void showinfo()
        {
            console.writeline("Name: " + name);
            console.writeline("id: " + id);
            console.writeline("cgpa: " + cgpa);

        }

    }
}
