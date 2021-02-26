using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;
using TaskManager.Enums;
using TaskManager.ValueObjects;

namespace TaskManager.Models
{
    public class User: Entity
    {
        public User(string name, Email email, DateTime signUpDate, bool isActive, List<Department> department, Company company)
        {
            Name = name;
            Email = email;
            SignUpDate = signUpDate;
            IsActive = isActive;
            this.Tasks = new HashSet<Task>();
            this.Departments = new HashSet<Department>();
            this.Departments = department;
            Company = company;
        }

        public User(string name, Email email, DateTime signUpDate, bool isActive, List<Department> department, Company company, List<Task>tasks)
        {
            Name = name;
            Email = email;
            SignUpDate = signUpDate;
            IsActive = isActive;
            this.Departments = new HashSet<Department>();
            this.Departments = department;
            this.Tasks = new HashSet<Task>();
            this.Tasks = tasks;
            Company = company;
        }

        public string Name { get;  private set; }
        public Email Email { get;  private set; }
        public DateTime SignUpDate { get;  private set; }
        public bool IsActive { get;  private set; }
        public bool IsAdmin { get; private set; }
        public string Password { get; private set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public Company Company { get; private set;}

        public override string ToString()
        {
            return $"{this.Name}";
        }

        public void SetAsAdmin()
        {
            this.IsAdmin = true;
        }
    }
}
