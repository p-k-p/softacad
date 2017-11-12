using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("Ivan Petrov", "Maths", 23);
            Student stu2 = new Student("Pesho Ivanov", "Maths", 25);
            Student stu3 = new Student("Gosho", "History", 31);

            stu1.ReceiveScholarship(4.0, 200M);
            stu2.ReceiveScholarship(4.0, 200M);
            stu3.ReceiveScholarship(4.0, 300M);

            stu2.UpYear();
            stu2.Grade = 5.0;

            StudentGroup math = new StudentGroup("Maths");
            math.AddStudent(stu1);
            math.AddStudent(stu2);
            math.PrintStudents();

            Console.WriteLine("Student with best grade: " + math.BestStudent());
            Console.ReadKey();


        }
    }
}
