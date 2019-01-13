﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiExample.Models
{
    public partial class PersondbContext : DbContext
    {
        public PersondbContext()
        {
        }

        public PersondbContext(DbContextOptions<PersondbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=dko-s010a-016\\sqlexpress;Initial Catalog=PersonDB;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Phone)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Phone_Person");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}