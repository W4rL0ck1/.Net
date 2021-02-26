using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlunosCursos.Models
{
    public class Course
    {
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
            Students = new List<Student>();
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
