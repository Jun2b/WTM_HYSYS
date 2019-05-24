using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using HYSYS.Models;
using WalkingTec.Mvvm.Core;

namespace HYSYS
{
    public class DataContext : FrameworkContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<MyUser> MyUsers { get; set; }

        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }

    }
}
