using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class StudentManger
    {
        private List<Student> students;

        public StudentManger()
        {
            students = new List<Student>();
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void addRandomStudent(int size)
        {
            Random rand = new Random();
            for (int i = 1; i <= size; i++)
            {
                String fisrtname = "FirstName " + i;
                String lastname = "Lastname " + i;
                String email = $"email{i}@example.com";
                string id = rand.Next(100000000, 999999999).ToString();
                string[] grades = new string[5];
                string phone = "050-" + rand.Next(1000000, 9999999).ToString();
                for (int j = 0; j < 5; j++)
                {
                    grades[j] = rand.Next(0, 101).ToString();
                }
                Student stud = new Student(id, fisrtname, lastname, email, phone, grades);
                addStudent(stud);
            }
        }

        public bool isStudentByid(string id)
        {
            foreach (Student student in students)
            {
                if (id == student.Id)
                    return true;
            }
            return false;
        }

        public bool isStudentByphone(string phone)
        {
            foreach (Student student in students)
            {
                if (phone == student.Phone)
                    return true;
            }
            return false;

        }
        public List<Student> GetStudents()
        {
            return students;
        }


        public List<Student> GetSortedStudentByAverage()
        {
            List<Student> sortedStudents = new List<Student>(students);
            BubbleSort(sortedStudents);

            return sortedStudents;
        }

        public void BubbleSort(List<Student> sortedStudents)
        {
            int n = sortedStudents.Count;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (sortedStudents[i - 1].AverageGrade() < sortedStudents[i].AverageGrade())
                    {
                        Student temp = sortedStudents[i];
                        sortedStudents[i] = sortedStudents[i - 1];
                        sortedStudents[i-1] = temp;
                        swapped = true;
                    }
    
                }
                n--;
            }
        }
    }
}
