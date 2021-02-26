using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlunosCursos.Models
{
    public class Student
    {   
        
        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
            Courses = new List<Course>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
