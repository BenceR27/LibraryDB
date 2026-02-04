using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryGUI.Models
{
    public partial class librarydbContext : DbContext
    {
        public librarydbContext()
        {
        }

        public librarydbContext(DbContextOptions<librarydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=librarydb;user=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.AuthorId)
                    .HasName("PRIMARY");

                entity.ToTable("authors");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("author_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthorName)
                    .HasColumnName("author_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PRIMARY");

                entity.ToTable("books");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("author_id");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id");

                entity.Property(e => e.BookId)
                    .HasColumnName("book_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("author_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publish_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("books_ibfk_1");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("books_ibfk_2");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
