﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sport_tovari_Belyaeva_3902.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class sporttovarEntities : DbContext
    {
        private static sporttovarEntities _context;
        public sporttovarEntities()
            : base("name=sporttovarEntities")
        {
        }


        public static sporttovarEntities GetContext()
        {
            if (_context == null)
                _context = new sporttovarEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kategorya> kategorya { get; set; }
        public virtual DbSet<Postavchik> Postavchik { get; set; }
        public virtual DbSet<punkt> punkt { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tovar> tovar { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<zakaz> zakaz { get; set; }
    }
}
