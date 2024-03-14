using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        public static void Main()
        {
            // Student collection
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            // upit i izvršavanje upita
            var rezultat = from student in studentList
                           where student.StudentName.Contains('o')
                           select student.StudentName;

            foreach (var rez in rezultat)
            {
                Console.WriteLine(rez);
            }
            Console.ReadLine();
        }
    }


    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

}

