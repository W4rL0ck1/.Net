using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Models;
using TaskManager.Enums;
using TaskManager.ValueObjects;
using TaskManager.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace TaskManagment
{
    public partial class Form1 : Form
    {
        #region CustomMethods
        public void InitializeDb()
        {
            Email email = new Email("renato@123.com");
            List<Department> departments = new List<Department>();
            List<Department> departments2 = new List<Department>();
            List<Department> departments3 = new List<Department>();
            List<User> users = new List<User>();
            List<Task> tasks = new List<Task>();
            departments.AddRange(new List<Department> {
                new Department("Administração"),
                new Department("RH"),
                new Department("Gerencia"),
                new Department("Limpeza"),
                new Department("T.I"),
            });
            departments2.Add(departments[1]);
            departments3.Add(departments[4]);


            Company company = new Company("ModalGR");
            User user = new User("Renato", email, DateTime.Now, true, departments3, company);
            User user1 = new User("AndrezinhoReiDelas", email, DateTime.Now, true, departments2, company);
            Task task = new Task("Pegar a manga e sair correndo", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now, users);
            Task task2 = new Task("DEU RUIM ", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now);
            tasks.Add(task); tasks.Add(task2);
            CheckoutProcess checkoutprocess = new CheckoutProcess("Pegar manga no quintal dos outros", departments[1], "pegar a manga ue", DateTime.Now, DateTime.Now, tasks);
            users.AddRange(new List<User> { user, user1 });
            user1.Tasks = tasks;
            user.Tasks.Add(task2);


            //MessageBox.Show(task.Id.ToString());
            //MessageBox.Show(company.ListAllUsers());


            DataContext db = new DataContext();
            db.CheckOutProcess.Add(checkoutprocess);
            db.Company.Add(company);
            db.User.AddRange(users);
            db.Department.AddRange(departments);
            db.SaveChanges();
            /*db.Department.Add(departments[0]);
            db.Task.Add(task2);
            db.SaveChanges();*/

        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDb();
        }
    }
}
