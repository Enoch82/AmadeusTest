﻿// <auto-generated />
using ApiBooksAmadeus.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiBooksAmadeus.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220720154346_Adding Book Model")]
    partial class AddingBookModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiBooksAmadeus.Model.BookModel", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("authors")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("isbn10")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("isbn13")
                        .HasColumnType("int");

                    b.Property<int>("pages")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("publisher")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("rating")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("subtitle")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("url")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("urlImage")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("bookId");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}