using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public class StudentGroup
    {
        public string groupSubject;
        public Student[] students;
        public int freePlaces;

        public StudentGroup()
        {
            freePlaces = 5;
            students = new Student[5];
        }

        public StudentGroup(string subject):this()
        {
            this.groupSubject = subject;
        }

        public void AddStudent(Student s)
        {
            if (this.freePlaces == 0)
            {
                Console.WriteLine("No more free places!");
                return;
            }
            else
            {

                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == null && this.groupSubject.Equals(s.subject))
                    {
                        students[i] = s;
                        this.freePlaces--;
                        break;
                    }
                }
            }
        }

        public void EmptyGroup()
        {
            this.freePlaces = 5;
            this.students = new Student[5];
        }

        public string BestStudent()
        {
            int bestIndex = 0;
            for (int i = 1; i < this.students.Length; i++)
            {
                if (students[i] == null)
                {
                    continue;
                }
                else if (students[i].Grade > students[bestIndex].Grade)
                {
                    bestIndex = i;
                }
            }

            return this.students[bestIndex].name;

        }

        public void PrintStudents()
        {
            for(int i = 0; i < this.students.Length; i++)
            {
                if (this.students[i] == null)
                {
                    continue;
                } else
                {
                    Console.WriteLine("Information for student number: " + (i+1));
                    Console.WriteLine("Name: " + this.students[i].name);
                    Console.WriteLine("Grade: " + this.students[i].Grade);
                    Console.WriteLine("Year in college: " + this.students[i].YearInCollege);
                    Console.WriteLine("Age: " + this.students[i].age);
                }
            }
        }
    }
}
