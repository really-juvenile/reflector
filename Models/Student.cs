using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflector.Models
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; } //total 2 autoproperties

       
        public Student()
        {

        }

        
        public Student(int rollno, string name)
        {
            RollNo = rollno;
            Name = name;
        } //2 constructors

        
        public void displayData()
        {
            Console.WriteLine("helllo");
           
        }
    }
}
