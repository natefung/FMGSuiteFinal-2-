﻿using FMGSuiteFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FMGSuiteFinal.DAL
{
    public class FMGSuiteContext : DbContext
    {
        public FMGSuiteContext() : base("FMGSuiteContext")
        {

        }

        public DbSet<FMG> fmg { get; set; }

        public System.Data.Entity.DbSet<FMGSuiteFinal.Models.Users> Users { get; set; }
    }
}