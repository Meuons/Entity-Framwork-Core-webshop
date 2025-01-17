﻿using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)

        {

        }

        public DbSet<User> Users { get; set; }
    }
}