using CyclingClub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingClub.Data
{
    internal class ClubMembershipDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string to the db (which is in the same location than where our code is
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
            //We pass the context otpions builder object to db context class.
            base.OnConfiguring(optionsBuilder);
        }

        //SQL Lite will use this to add and retrieve data from the db
        //after doing this you have to run ``` Add-Migration FirstCreate``` to creeate a db from this model
        //What is generated is a method to create and delete 
        //To run the creation script you need to run ```update-database```
        public DbSet<User> Users { get; set; }
    }
}
