﻿using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Context
{
    public class MySqlContext:DbContext
    {
        public MySqlContext()
        {

        }
        public MySqlContext(DbContextOptions<MySqlContext> options):base(options){}

        public DbSet<Person> Persons { get; set; }


    }
}
