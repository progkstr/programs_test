﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace check_cafe
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SQL_Cafe : DbContext
    {
        public SQL_Cafe()
            : base("name=SQL_Cafe")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new _class.mapChange());
            modelBuilder.Configurations.Add(new _class.MapClient());
            modelBuilder.Configurations.Add(new _class.mapEmployee());
            modelBuilder.Configurations.Add(new _class.mapPerson());
            modelBuilder.Configurations.Add(new _class.mapTable());
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Change> Change { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Table> Table { get; set; }
    }
}
