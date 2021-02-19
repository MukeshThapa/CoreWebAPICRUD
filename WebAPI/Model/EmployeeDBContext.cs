﻿
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext>options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}