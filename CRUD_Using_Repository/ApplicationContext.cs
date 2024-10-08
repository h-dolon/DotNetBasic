﻿using CRUD_Using_Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Using_Repository
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            
        }
        public DbSet<User>Users { get; set; }
    }
}
