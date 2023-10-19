using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IskolaAPI.Models;

public partial class iskolaContext : DbContext
{
    public iskolaContext()
    {
    }

    public iskolaContext(DbContextOptions<iskolaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<diakok> diakok { get; set; }

    public virtual DbSet<tanarok> tanarok { get; set; }

    public virtual DbSet<vezetok> vezetok { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user id=root;database=iskola", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<diakok>(entity =>
        {
            entity.HasKey(e => e._).HasName("PRIMARY");

            entity.Property(e => e._).ValueGeneratedNever();
        });

        modelBuilder.Entity<tanarok>(entity =>
        {
            entity.HasKey(e => e._).HasName("PRIMARY");

            entity.Property(e => e._).ValueGeneratedNever();
        });

        modelBuilder.Entity<vezetok>(entity =>
        {
            entity.HasKey(e => e._).HasName("PRIMARY");

            entity.Property(e => e._).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
