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
    [Migration("20220720155241_Adding Store Model and RelationShip with Book Model")]
    partial class AddingStoreModelandRelationShipwithBookModel
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

                    b.Property<int>("storeId")
                        .HasColumnType("int");

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

                    b.HasIndex("storeId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("ApiBooksAmadeus.Model.StoreModel", b =>
                {
                    b.Property<int>("storeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("delivery")
                        .HasColumnType("bit");

                    b.Property<string>("openTime")
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("parking")
                        .HasColumnType("bit");

                    b.Property<string>("phone")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("phoneDelivery")
                        .HasColumnType("varchar(500)");

                    b.HasKey("storeId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("ApiBooksAmadeus.Model.BookModel", b =>
                {
                    b.HasOne("ApiBooksAmadeus.Model.StoreModel", "Store")
                        .WithMany("Books")
                        .HasForeignKey("storeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("ApiBooksAmadeus.Model.StoreModel", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
