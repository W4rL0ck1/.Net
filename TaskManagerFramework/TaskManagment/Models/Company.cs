﻿using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
    public class Company : Entity
    {
        public Company(string name)
        {
            Name = name;
            this.Users = new HashSet<User>();
        }
        public Company(string name, List<User> user)
        {
            Name = name;
            this.Users = new HashSet<User>();
            this.Users = user;
        }

        #region attributes        
        public string Name { get; private set; }
        public string CNPJ { get; private set; }
        public virtual ICollection<User> Users { get; set; }
        #endregion

        #region Methods
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
        public string ListAllUsersNames()
        {
            var aux = "";
            int count = 1;
            foreach (var item in Users)
            {
                aux += $"{count}.{item.Name} || ";
                count++;
            }
            count = 1;
            return aux;
        }
        #endregion
    }
}
