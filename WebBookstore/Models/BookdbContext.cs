using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebBookstore.Models
{
    public partial class BookdbContext : DbContext
    {
        public BookdbContext()
        {
        }

        public BookdbContext(DbContextOptions<BookdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookstore> Bookstores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:marketdb.database.windows.net,1433;Initial Catalog=Bookdb;Persist Security Info=False;User ID=Virat;Password=abc@123@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookstore>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__bookstor__3DE0C2077FFB4D87");

                entity.ToTable("bookstore");

                entity.Property(e => e.BookId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BookCategory).HasMaxLength(50);

                entity.Property(e => e.BookName).HasMaxLength(50);

                entity.Property(e => e.PublisherName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
