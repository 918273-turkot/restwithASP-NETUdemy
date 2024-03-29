﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model.Context
{

    public class MySqlContext:DbContext
    {
       public MySqlContext()
        {

        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) /*Passa para base que estende options*/
        {
        }
        public DbSet<Person> Persons { get; set; }/*Para mapear tabela*/

    }
}
