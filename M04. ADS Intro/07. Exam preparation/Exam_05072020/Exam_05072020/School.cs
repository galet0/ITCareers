using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05072020
{
    public class School
    {
        private string name;
        private List<Student> students;

        public School()
        {
            this.students = new List<Student>();
        }

        public School(string name) : this()
        {
            this.Name = name;
        }

        public IReadOnlyList<Student> Students => this.students;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name, grade);
            this.students.Add(student);
        }

        public void SortAscendingByName()
        {
            this.students = this.students.OrderBy(s => s.Name).ToList();
        }

        public void SortDescendingByGrade()
        {
            this.students = this.students.OrderByDescending(s => s.Grade).ToList();
        }

        public bool CheckStudentIsInSchool(string name)
        {
            return this.students.Where(s => s.Name.Equals(name)).FirstOrDefault() != null;
        }

        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> removed = this.students.Where(s => s.Grade < grade).Select(s => s.Name).ToList();

            //int countOfRemovedStudents = this.students.RemoveAll(s => s.Grade < grade);

            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Grade < grade)
                {
                    this.students.RemoveAt(i);
                }
            }

            return removed;
        }

        public double AverageResultInRange(int start, int end)
        {
            return this.GetStudentsinRange(start, end).Average(s => s.Grade);
        }

        public string[] ProvideInformationAboutAllStudents()
        {
            string[] studentsInfo = new string[this.students.Count];
            for (int i = 0; i < this.students.Count; i++)
            {
                studentsInfo[i] = this.students[i].ToString();
            }

            return studentsInfo;
        }
        private List<Student> GetStudentsinRange(int start, int end)
        {
            return this.students.GetRange(start, end - start + 1);
        }
    }
}
