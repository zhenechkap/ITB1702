﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Facade;

namespace Infra
{
    public class Employees
    {
        public static List<Employee> Get(SalesDbContext db)
        {
            return db.Employees.ToList();
        }

        public Employee Save(Employee e, SalesDbContext db)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            return e;
        }

        public static bool IsValidUser(UserDetails user)
        {
            return user.UserName == "Admin" && user.Password == "Admin";
        }

        public void UploadEmployees(List<Employees> employees, SalesDbContext db)
        {
            db.Employees.AddRange(employees);
            db.SaveChanges();
        }
    }
}
