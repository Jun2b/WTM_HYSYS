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
        public DbSet<Location> Locations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreIn> StoreIns { get; set; }
        public DbSet<StoreInPrice> StroreStoreInPrices { get; set; }


        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {

        }

    }
}
