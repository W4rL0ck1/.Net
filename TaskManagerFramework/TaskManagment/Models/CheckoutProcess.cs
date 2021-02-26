using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
   public class CheckoutProcess : Entity
    {
        public CheckoutProcess(string name, Department department, string description, DateTime startDate, DateTime endDate, List<Task> task)
        {
            Name = name;
            Department = department;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            this.Tasks = new HashSet<Task>();
            this.Tasks = task;
        }

        public string Name { get; private set; }
        public Department Department { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public virtual ICollection<Task> Tasks { get;  set; }

        public bool CheckProcessStatus()
        {
            return false;
        }
        public bool CheckTasksStatus()
        {
            return false;
        }

        public void StartTask(Task task)
        {
            task.SetStarted();

            //implementar inicialização da task
            //verifica se PredecessorTaskStatus == true
        }

        public void EndTask(Task task)
        {
            //implementar atualização da task
        }

        public void DeleteTask(Task task)
        {
            //implementar remoção da task
        }

        public void UpdateTask(Task task)
        {
            //implementar atualização da task
        }
    }
}
