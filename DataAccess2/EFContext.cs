﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new DbInitializer());
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}