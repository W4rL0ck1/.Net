
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.ValueObjects
{
    public class Role : Notifiable
    {
        public Role(string rolename)
        {
            RoleName = rolename;
        }
        public string RoleName { get;  set; }
        public override string ToString()
        {
            return RoleName;
        }
    }
}