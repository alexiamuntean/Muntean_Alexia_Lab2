﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Muntean_Alexia_Lab2.Data;

#nullable disable

namespace Muntean_Alexia_Lab2.Migrations
{
    [DbContext(typeof(Muntean_Alexia_Lab2Context))]
    [Migration("20231025115908_InitialAuthors")]
    partial class InitialAuthors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.BookCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("CategoryID");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Book", b =>
                {
                    b.HasOne("Muntean_Alexia_Lab2.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID");

                    b.HasOne("Muntean_Alexia_Lab2.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.BookCategory", b =>
                {
                    b.HasOne("Muntean_Alexia_Lab2.Models.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muntean_Alexia_Lab2.Models.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Category", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Muntean_Alexia_Lab2.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
