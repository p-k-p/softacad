using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Chovek = new Person("Acho", 25, true);
            Student Pesho = new Student("Pesho", 22, true, 5.5d);
            Employee Fifi = new Employee("Fifi", 21, false, 50M);

            Chovek.ShowPersonInfo();
            Pesho.ShowStudentInfo();
            Fifi.ShowEmployeeInfo();

            decimal overtime = Fifi.CalculateOvertime(2d);
            Console.WriteLine("Overtime salary: " + overtime);
            Console.ReadKey();
        }
    }
}
