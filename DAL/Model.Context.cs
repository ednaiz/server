﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnSpotEntities : DbContext
    {
        public OnSpotEntities()
            : base("name=OnSpotEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendency> Attendency { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<LessonToCourse> LessonToCourse { get; set; }
        public virtual DbSet<StudentToCourse> StudentToCourse { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
