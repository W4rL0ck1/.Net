using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteAlunosCursos.DataContext;
using TesteAlunosCursos.Models;

namespace TesteAlunosCursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CriaAluno();
        }

        static void CriaAluno()
        {
            Student student = new Student(1, "Renato");
            Course course = new Course(1, "Curso de TI");
            Course course2 = new Course(2, "Java");
            Course course3 = new Course(3, "C#");
            student.Courses.Add(course); 
            student.Courses.Add(course2); 
            student.Courses.Add(course3);

            SchoolDbContext db = new SchoolDbContext();
            db.Students.Add(student);
            db.Courses.Add(course);
            db.SaveChanges();

            foreach (var item in student.Courses)
            {
                MessageBox.Show(item.CourseName);
            }

        }
    }
}
